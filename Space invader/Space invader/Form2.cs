using System;
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
        public Form2(PLayer player)
        {
            InitializeComponent();
            play = player;
            SpaceShip.Image = play.spaceship.Image;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
