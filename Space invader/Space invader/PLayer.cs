using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public class PLayer : Form
    {
        public int hp { get; set; }
        public int point { get; set; }
        public int lvl { get; set; }
        public string name { get; set; }
        public PictureBox spaceship { get; set; } = new PictureBox();
        
        public PLayer ()
        {
            
            hp = 100;
            point = 0;
            lvl = 1;
        }
    }
}
