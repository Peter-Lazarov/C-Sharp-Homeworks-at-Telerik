using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public static class Distance
    {
        private static double deltha(double a, double b)
        {
            return (b - a) * (b - a);
        }
        public static double Calc(Point3D first, Point3D second)
        {
            double temp = deltha(first.x, second.x) + deltha(first.y, second.y) + deltha(first.z, second.z);
            return Math.Sqrt(temp);
        }
    }
}
