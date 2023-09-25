using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Space_invader
{
    public partial class Form2 : Form
    {
       

        Player play;
        bool goLeft, goRight, goUp, goDown;
        bool shooting ,isGameOver;
        int enemyBulletTimer, enemySpeed;
        bool enemyGoLeft, enemyGoRight;
        Invaders[] invaders;
        List <Invaders> invadersListBottom =  new List<Invaders>();
        List<Invaders> invadersListTop = new List<Invaders>();
        public Form2(Player player)
        {
            InitializeComponent();
            play = player;
            SpaceShip.Image = play.spaceship.Image;
            gameSetup();
            Debug.WriteLine(this.ClientSize.ToString());
        }
       

        private void gameSetup()
        {
            txtScore.Text = "score : 0";
            enemyBulletTimer = 300;
            enemySpeed = 2;
            shooting = false;
            enemyGoLeft = true;
            enemyGoRight = false;
            makeInvadersList();
            GameTimer.Start();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
           
            txtScore.Text = "Score: " + play.score;
            if (goLeft)
            {
                SpaceShip.Left -=play.speed;
            }
            if (goRight)
            {
                SpaceShip.Left += play.speed;
            }
            enemyBulletTimer -= 10;
            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                //makeBullet("sadBullet");
            }
           
            if (invadersListBottom.ElementAt(invadersListBottom.Count -1).PictureBox.Left > 1820  || invadersListTop.ElementAt(invadersListTop.Count -1).PictureBox.Left > 1820)
            {
                invadersListTop = invadersListTop.Select(obj => { obj.PictureBox.Top = obj.PictureBox.Top + 20; return obj; }).ToList();
                invadersListBottom = invadersListBottom.Select(obj => { obj.PictureBox.Top = obj.PictureBox.Top + 20; return obj; }).ToList();
                enemyGoRight = true;
                enemyGoLeft = false;
            }
            if (invadersListBottom.ElementAt(0).PictureBox.Left < 0)
            {
                invadersListTop = invadersListTop.Select(obj => { obj.PictureBox.Top = obj.PictureBox.Top + 20; return obj; }).ToList();
                invadersListBottom = invadersListBottom.Select(obj => { obj.PictureBox.Top = obj.PictureBox.Top + 20; return obj; }).ToList();
                enemyGoRight = false;
                enemyGoLeft = true;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "TopInvaders"  || (string)x.Tag == "BottomInvaders"))
                {
                    if (enemyGoLeft)
                    {
                        x.Left += enemySpeed;
                    }
                    if (enemyGoRight)
                    {
                        x.Left -= enemySpeed;
                    }
                    
                    if (x.Bounds.IntersectsWith(SpaceShip.Bounds))
                    {
                        gameOver("You've been invaded by the sad invaders, you are now sad!");
                    }
                    foreach (Control y in this.Controls)
                    {
                        if (y is PictureBox && (string)y.Tag == "bullet")
                        {
                            if (y.Bounds.IntersectsWith(x.Bounds))
                            {
                                if ((string)x.Tag == "TopInvaders")
                                {
                                    int index = invadersListTop.FindIndex(a => a.PictureBox.Name == (x.Name));
                                    invadersListTop.ElementAt(index).HP -= play.damage;
                                    if (invadersListTop.ElementAt(index).HP <= 0)
                                    {
                                        this.Controls.Remove(x);
                                        invadersListTop.RemoveAt(index);
                                    }
                                } else if ((string) x.Tag == "BottomInvaders")
                                {
                                    int index = invadersListBottom.FindIndex(a => a.PictureBox.Name == (x.Name));
                                    invadersListBottom.ElementAt(index).HP -= play.damage;
                                    if (invadersListBottom.ElementAt(index).HP <= 0)
                                    {
                                        this.Controls.Remove(x);
                                        invadersListBottom.RemoveAt(index);
                                    }
                                }
                                
                                this.Controls.Remove(y);
                                play.score += 1;
                                shooting = false;
                            }
                        }
                    }
                }else
                {
                    if (x is PictureBox && (string)x.Tag == "bullet")
                    {
                        x.Top -= 40;
                        if (x.Top < 15)
                        {
                            this.Controls.Remove(x);
                            
                            shooting = false;
                        }
                    }
                    if (x is PictureBox && (string)x.Tag == "sadBullet")
                    {
                        x.Top += 40;
                        if (x.Top > 1100)
                        {
                            this.Controls.Remove(x);
                        }
                        if (x.Bounds.IntersectsWith(SpaceShip.Bounds))
                        {
                            this.Controls.Remove(x);
                            gameOver("You've been killed by the sad bullet. Now you are sad forever!");
                        }
                    }
                }
              
            }
            if (play.score > 20)
            {
                enemySpeed = 15;
            }
            if (play.score == 30 )
            {
                gameOver("Woohoo Happiness Found, Keep it safe!");
            }
           
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && !shooting)
            {
                shooting = true;
                makeBullet("bullet");
            }
            if ((e.KeyCode == Keys.Enter) && isGameOver)
            {
                removeAll();
            }
        }
        private void removeAll()
        {
            foreach (Invaders i in invaders)
            {
                this.Controls.Remove(i.PictureBox);
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "sadBullet")
                    {
                        this.Controls.Remove(x);
                    }
                }
            }

        }
        private void gameOver(string message)
        {
            GameTimer.Stop();
            isGameOver = true;
            txtScore.Text = "Score: " + play.score + " " + message;
            
        }

        private void makeBullet(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.laserBlue01;
            bullet.Size = new Size(25, 50);
            bullet.Tag = bulletTag;
            bullet.Left = SpaceShip.Left + SpaceShip.Width / 2;
            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = SpaceShip.Top - 20;
            }
            else if ((string)bullet.Tag == "sadBullet")
            {
                bullet.Top = -100;
            }
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void makeInvaders()
        {
            invaders = new Invaders[30];
            int left = 0;
            for (int i = 0; i < invaders.Length/2; i++)
            {
                invaders[i] = new Invaders();
                invaders[i].PictureBox.Size = new Size(100, 80);
                invaders[i].PictureBox.Image = Properties.Resources.enemyBlue1;
                invaders[i].PictureBox.Top = 10;
                invaders[i].PictureBox.Tag = "sadInvaders";
                invaders[i].PictureBox.Left = left;
                invaders[i].PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invaders[i].speed = enemySpeed;
                this.Controls.Add(invaders[i].PictureBox);
                left = left + 110;
            }
            left = 0;
            for (int i = invaders.Length / 2; i < invaders.Length; i++)
            {
                invaders[i] = new Invaders();
                invaders[i].PictureBox.Size = new Size(100, 80);
                invaders[i].PictureBox.Image = Properties.Resources.enemyBlue1;
                invaders[i].PictureBox.Top = 90;
                invaders[i].PictureBox.Tag = "sadInvaders";
                invaders[i].PictureBox.Name = i.ToString();
                invaders[i].PictureBox.Left = left;
                invaders[i].PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invaders[i].speed = enemySpeed;
                this.Controls.Add(invaders[i].PictureBox);
                left = left + 110;
            }
        }
        private void makeInvadersList()
        {
            int len = 30;
            int left = 0;
            for (int i = 0; i < (len / 2); i++)
            {
                Invaders invader = new Invaders();
                invader.PictureBox.Size = new Size(100, 80);
                invader.PictureBox.Image = Properties.Resources.enemyBlue1;
                invader.PictureBox.Top = 10;
                invader.PictureBox.Name= i.ToString();
                invader.PictureBox.Tag = "TopInvaders";
                invader.PictureBox.Left = left;
                invader.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invader.speed = enemySpeed;
                this.Controls.Add(invader.PictureBox);
                invadersListTop.Add(invader);
                left = left + 110;
            }
            left = 0;
            for (int i = 0; i < (len / 2); i++)
            {
                Invaders invader = new Invaders();
                invader.PictureBox.Size = new Size(100, 80);
                invader.PictureBox.Image = Properties.Resources.enemyBlue1;
                invader.PictureBox.Top = 90;
                invader.PictureBox.Name = i.ToString();
                invader.PictureBox.Tag = "BottomInvaders";
                invader.PictureBox.Left = left;
                invader.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invader.speed = enemySpeed;
                this.Controls.Add(invader.PictureBox);
                invadersListBottom.Add(invader);
                left = left + 110;
            }
        }




    }
}
