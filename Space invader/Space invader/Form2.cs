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
       

        Player play = new Player();
        bool goLeft, goRight, goUp, goDown;
        int len = 30;
        bool shooting ,isGameOver;
        int enemyBulletTimer, enemySpeed;
        bool enemyGoLeft, enemyGoRight;
        List <Invaders> invadersListBottom =  new List<Invaders>();
        List<Invaders> invadersListTop = new List<Invaders>();
        
        public Form2(Player player)
        {
            InitializeComponent();
            play = player;
            SpaceShip.Image = play.spaceship.Image;
            gameSetup();
            Debug.WriteLine(this.ClientSize.ToString());
            play.difficulty = player.difficulty;
        }


         private void gameSetup()
        {
            txtScore.Text = "score : 0";
            play.score = 0;
            play.hp = 75;
           
            if (play.difficulty == "facile")
            {
                enemyBulletTimer = 600;
                enemySpeed = 2;
                play.damage = 75;
            }
            else if (play.difficulty == "diff")
            {
                enemyBulletTimer = 500;
                enemySpeed = 4;
                play.damage = 45;
            }
            else if (play.difficulty == "impo")
            {
                enemyBulletTimer = 300;
                enemySpeed = 6;
                play.damage = 25;
            }
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
                if (play.difficulty == "facile")
                {
                    enemyBulletTimer = 600;
                }
                else if (play.difficulty == "diff")
                {
                    enemyBulletTimer = 500;
                }
                else if (play.difficulty == "impo")
                {
                    enemyBulletTimer = 300;
                }
                makeBullet("InvaderBullet");
            }
           
            if (invadersListBottom.ElementAt(invadersListBottom.Count -1).PictureBox.Left > 1200  || invadersListTop.ElementAt(invadersListTop.Count -1).PictureBox.Left > 1200)
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
                                        play.score += 1;
                                        this.Controls.Remove(x);
                                        invadersListTop.RemoveAt(index);
                                    }
                                    else if (invadersListTop.ElementAt(index).HP <= 25)
                                    {
                                        invadersListTop.ElementAt(index).PictureBox.Image = Properties.Resources.enemyBlack1;
                                    }
                                    else if (invadersListTop.ElementAt(index).HP <= 50)
                                    {
                                        invadersListTop.ElementAt(index).PictureBox.Image = Properties.Resources.enemyRed1;
                                    }
                                    else if (invadersListTop.ElementAt(index).HP <= 75)
                                    {
                                        invadersListTop.ElementAt(index).PictureBox.Image = Properties.Resources.enemyBlue1;
                                    }
                                } else if ((string)x.Tag == "BottomInvaders")
                                {
                                    int index = invadersListBottom.FindIndex(a => a.PictureBox.Name == (x.Name));
                                    invadersListBottom.ElementAt(index).HP -= play.damage;

                                    if (invadersListBottom.ElementAt(index).HP <= 0)
                                    {
                                        play.score += 1;
                                        this.Controls.Remove(x);
                                        invadersListBottom.RemoveAt(index);
                                    } else if (invadersListBottom.ElementAt(index).HP <= 25)
                                    {
                                        invadersListBottom.ElementAt(index).PictureBox.Image = Properties.Resources.enemyBlack2 ;
                                    } else if (invadersListBottom.ElementAt(index).HP <= 50)
                                    {
                                        invadersListBottom.ElementAt(index).PictureBox.Image = Properties.Resources.enemyRed2;
                                    }
                                    else if (invadersListBottom.ElementAt(index).HP <= 75)
                                    {
                                        invadersListBottom.ElementAt(index).PictureBox.Image = Properties.Resources.enemyBlue2;
                                    }
                                }
                                this.Controls.Remove(y);
                                shooting = false;
                            }
                        }
                    }
                }else
                {
                    if (x is PictureBox && (string)x.Tag == "bullet")
                    {
                        x.Top -= 20;
                        if (x.Top < 10)
                        {
                            this.Controls.Remove(x);
                            
                            shooting = false;
                        }
                    }
                    if (x is PictureBox && (string)x.Tag == "InvaderBullet")
                    {
                        x.Top += 20;
                        if (x.Top > 800)
                        {
                            this.Controls.Remove(x);
                        }

                        if (x.Bounds.IntersectsWith(SpaceShip.Bounds))
                        {
                            play.hp -= 25;
                            if (play.hp <= 0)
                            {
                                
                                gameOver("You've been killed by the Invaders\n" + "your score is  : " + play.score.ToString() + "\n do you want to retry ?");
                            } else if (play.hp <=25)
                            {
                                this.healthBarImage.Image = Properties.Resources.min_health_bar;
                            } else if (play.hp <=50)
                            {
                                this.healthBarImage.Image = Properties.Resources.mid_health_bar;
                            }
                            this.Controls.Remove(x);
                        }
                    }
                }
              
            }
            if (play.score >= len /2)
            {
                enemySpeed = 10;
            }
            if ( play.score == len)
            {
                gameOver("You win\n" + "\"your score is : " + play.score.ToString() + "do you want to retry ?");
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
            foreach (Invaders i in invadersListBottom)
            {
                this.Controls.Remove(i.PictureBox);
            }
            foreach (Invaders i in invadersListTop)
            {
                this.Controls.Remove(i.PictureBox);
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "bullet" || (string)x.Tag == "InvaderBullet")
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
            string title = "End window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result =  MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form = new Form2(play);
                form.Show();
            }
            else
            {
                this.Close();
                Form form2 = new Form1(play);
                form2.Show();
            }
            
        }

        private void makeBullet(string bulletTag)
        {
            PictureBox bullet = new PictureBox();
            bullet.Image = Properties.Resources.laserBlue15;
            bullet.Size = new Size(15, 30);
            bullet.Tag = bulletTag;
            bullet.Left = SpaceShip.Left + SpaceShip.Width / 2;
            if ((string)bullet.Tag == "bullet")
            {
                bullet.Top = SpaceShip.Top - 20;
            }
            else if ((string)bullet.Tag == "InvaderBullet")
            {
                bullet.Top = -100;
            }
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void makeInvadersList()
        {
           
            int left = 0;
            for (int i = 0; i < (len / 2); i++)
            {
                Invaders invader = new Invaders();
                invader.PictureBox.Size = new Size(50, 30);
                invader.PictureBox.Image = Properties.Resources.enemyGreen1;
                invader.PictureBox.Top = 10;
                invader.PictureBox.Name= i.ToString();
                invader.PictureBox.Tag = "TopInvaders";
                invader.PictureBox.Left = left;
                invader.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invader.speed = enemySpeed;
                this.Controls.Add(invader.PictureBox);
                invadersListTop.Add(invader);
                left = left + 60;
            }
            left = 0;
            for (int i = 0; i < (len / 2); i++)
            {
                Invaders invader = new Invaders();
                invader.PictureBox.Size = new Size(50, 30);
                invader.PictureBox.Image = Properties.Resources.enemyGreen2;
                invader.PictureBox.Top = 40;
                invader.PictureBox.Name = i.ToString();
                invader.PictureBox.Tag = "BottomInvaders";
                invader.PictureBox.Left = left;
                invader.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invader.speed = enemySpeed;
                this.Controls.Add(invader.PictureBox);
                invadersListBottom.Add(invader);
                left = left + 60;
            }
        }

    }
}
