using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_invader
{
    public class Player 
    {
        public int hp { get; set; }
        public int score { get; set; }
        public int speed { get; set; }
        public int damage { get; set; }
        public PictureBox spaceship { get; set; } = new PictureBox();
        public string difficulty { get; set; }
        
        public Player ()
        {
            hp = 75;
            score = 0;
            speed = 8;

        }
    }
}
