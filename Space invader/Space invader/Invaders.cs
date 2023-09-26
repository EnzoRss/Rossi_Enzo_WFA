using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public class Invaders
    {
        public int HP { get; set; }
        public PictureBox PictureBox { get; set; }
        public int  speed { get; set; }
        public int damage { get; set; }


        public Invaders() 
        {
            HP = 100;
            damage = 50;
            speed = 0;
            PictureBox = new PictureBox();
       }
    }
}
