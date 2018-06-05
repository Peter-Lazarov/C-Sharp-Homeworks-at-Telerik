using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    [VersionAttribute(1,2)]
    public struct Point3D
    {
        //Write a static class with a static method to calculate the distance between two points in the 3D space.
        //Properties
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        private static readonly decimal o = 0m;
        
        public override string ToString()
        {
            string point = string.Format("{0} {1} {2}", x, y, z);
            return point;
        }

        public string pointO()
        {
            return string.Format("{0} {0} {0}", o);
        }

        //Constructor
        public Point3D(double xcoord, double ycoord, double zcoord) : this()
        {
            this.x = xcoord;
            this.y = ycoord;
            this.z = zcoord;
        }
    }
}
