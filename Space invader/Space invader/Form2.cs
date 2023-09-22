﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Space_invader
{
    public partial class Form2 : Form
    {

        PLayer play;
        bool goLeft, goRight, goUp, goDown;
        bool shooting ,isGameOver;
        int enemyBulletTimer, enemySpeed;
        Invaders[] invaders = new Invaders[15] ;   
        public Form2(PLayer player)
        {
            InitializeComponent();
            play = player;
            SpaceShip.Image = play.spaceship.Image;
            gameSetup();
        }


        private void gameSetup()
        {
            txtScore.Text = "score : 0";
            enemyBulletTimer = 300;
            enemySpeed = 5;
            shooting = false;
            makeInvaders();
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
                SpaceShip.Left -= play.speed;
            }
            if (goRight)
            {
                SpaceShip.Left += play.speed;
            }
            enemyBulletTimer -= 10;
            if (enemyBulletTimer < 1)
            {
                enemyBulletTimer = 300;
                makeBullet("sadBullet");
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "sadInvaders")
                {
                    x.Left += enemySpeed;
                    if (x.Left > 1990)
                    {
                        x.Top += 65;
                        x.Left = -80;
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
                                this.Controls.Remove(x);
                                this.Controls.Remove(y);
                                play.score += 1;
                                shooting = false;
                            }
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Top -= 40;
                   /* if (x.Top < 15)
                    { 
                        this.Controls.Remove(x);
                        shooting = false;
                    }*/
                }
                if (x is PictureBox && (string)x.Tag == "sadBullet")
                {
                    x.Top += 40;
                    /*if (x.Top > 1100)
                    {
                        this.Controls.Remove(x);
                    }
                    if (x.Bounds.IntersectsWith(SpaceShip.Bounds))
                    {
                        this.Controls.Remove(x);
                        gameOver("You've been killed by the sad bullet. Now you are sad forever!");
                    }*/
                }
            }
            if (play.score > 8)
            {
                enemySpeed = 25;
            }
            if (play.score == invaders.Length)
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
            bullet.Show();
        }

        private void makeInvaders()
        {
            invaders = new Invaders[10];
            int left = 0;
            for (int i = 0; i < invaders.Length; i++)
            {
                invaders[i] = new Invaders();
                invaders[i].PictureBox.Size = new Size(100, 80);
                invaders[i].PictureBox.Image = Properties.Resources.enemyBlue1;
                invaders[i].PictureBox.Top = 100;
                invaders[i].PictureBox.Tag = "sadInvaders";
                invaders[i].PictureBox.Left = left;
                invaders[i].PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                invaders[i].speed = enemySpeed;
                this.Controls.Add(invaders[i].PictureBox);
                left = left - 150;
            }
        }
    }
}