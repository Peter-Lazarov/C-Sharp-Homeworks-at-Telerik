using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class Map
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Map () : this (0,0)
        {
                
        }

        public Map (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
