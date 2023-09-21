using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public partial class Form1 : Form
    {


        bool isCheked;
        PLayer play;
        public Form1(PLayer player)
        {
            InitializeComponent();
            play = player;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            (new Form2(play)).Show();
        }
        private void MainGameTImer(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioBtnBlue.Checked)
            {
                play.spaceship.Image = Properties.Resources.playerShip1_blue ;
                isCheked = true;
            }
            if (radioBtnGreen.Checked)
            {
                play.spaceship.Image = Properties.Resources.playerShip1_green;
                isCheked = true;
            }
            if (radioBtnRed.Checked)
            {
                play.spaceship.Image = Properties.Resources.playerShip1_red;
                isCheked = true;
            }
            if (radioBtnOrange.Checked)
            {
                play.spaceship.Image = Properties.Resources.playerShip1_orange;
                isCheked = true;
            }

            if (isCheked)
            {
               this.Close();
            }
                
            

        }

        private void radioBtn_blue_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
