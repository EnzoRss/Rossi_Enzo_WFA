using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public class PLayer 
    {
        public int hp { get; set; }
        public int score { get; set; }
        public int lvl { get; set; }
        public int speed;
        public PictureBox spaceship { get; set; } = new PictureBox();
        
        public PLayer ()
        {
            hp = 100;
            score = 0;
            lvl = 1;
            speed = 25;

        }
    }
}
