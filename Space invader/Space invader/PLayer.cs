using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_invader
{
    public class PLayer
    {
        public int hp { get; set; }
        public int point { get; set; }
        public int lvl { get; set; }
        public string name { get; set; }
        
        public PLayer (string name)
        {
            this.name = name;
            hp = 100;
            point = 0;
            lvl = 1;
        }
    }
}
