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
        Player play;
        public Form1(Player player)
        {
            InitializeComponent();
            play = player;
            


        }
       
        private void MainGameTImer(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioBtnModel2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnModel4_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioBtnModel1.Checked)
            {
                play.spaceship.Image = radioBtnModel1.Image;
                isCheked = true;
            }
            if (radioBtnModel2.Checked)
            {
                play.spaceship.Image = radioBtnModel2.Image;
                isCheked = true;
            }
            if (radioBtnModel4.Checked)
            {
                play.spaceship.Image = radioBtnModel4.Image; ;
                isCheked = true;
            }
            if (radioBtnModel3.Checked)
            {
                play.spaceship.Image = radioBtnModel3.Image; ;
                isCheked = true;
            }

            if (isCheked)
            {
               this.Close();
               (new Form2(play)).Show();
            }
                
            

        }

        private void radioBtnModel1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnModel3_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void radioBtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnModel1.Image = Properties.Resources.playerShip1_blue ;
            radioBtnModel2.Image = Properties.Resources.playerShip2_blue ;
            radioBtnModel3.Image = Properties.Resources.playerShip3_blue ;
            radioBtnModel4.Image = Properties.Resources.ufoBlue;
        }

        private void radioBtnRed_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnModel1.Image = Properties.Resources.playerShip1_red;
            radioBtnModel2.Image = Properties.Resources.playerShip2_red;
            radioBtnModel3.Image = Properties.Resources.playerShip3_red;
            radioBtnModel4.Image = Properties.Resources.ufoRed;

        }
        private void radioBtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnModel1.Image = Properties.Resources.playerShip1_green;
            radioBtnModel2.Image = Properties.Resources.playerShip2_green;
            radioBtnModel3.Image = Properties.Resources.playerShip3_green;
            radioBtnModel4.Image = Properties.Resources.ufoGreen;

        }
        private void radioBtnOrange_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnModel1.Image = Properties.Resources.playerShip1_orange;
            radioBtnModel2.Image = Properties.Resources.playerShip2_orange;
            radioBtnModel3.Image = Properties.Resources.playerShip3_orange;
            radioBtnModel4.Image = Properties.Resources.ufoYellow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
