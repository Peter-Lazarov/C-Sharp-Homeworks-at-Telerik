using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static double DegtoRad(double angle)
        {
            return Math.PI * angle / 180;
        }
        static double RadtoDeg(double angle)
        {
            return angle / (180 * Math.PI);
        }
        static void Main()
        {
            double a = 10;
            double b = 7;
            double angle = 25;
            angle = DegtoRad(angle);

            double surface = (a * b * Math.Sin(angle))/2;
            Console.WriteLine("{0:0.00}",surface);
        }
    }
}
