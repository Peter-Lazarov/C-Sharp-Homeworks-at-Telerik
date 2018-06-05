using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    class Display
    {
        double size;
        long colors;

        public Display()
        {
        }
        public Display(double displaySize, long displayColors)
        {
            this.size = displaySize;
            this.colors = displayColors;
        }
        public double DisplaySize
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public long DisplayColors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }
    }
}
