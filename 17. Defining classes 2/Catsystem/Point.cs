using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsystem
{
    public struct Point
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public string GetCoordinates()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }
    }
}
