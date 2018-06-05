using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Point_within_circle_and_rectagle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type point x and y coordinate to check position");
            int ix = Convert.ToInt32(Console.ReadLine());
            int iy = Convert.ToInt32(Console.ReadLine());

            int px = ix - 1;
            int py = iy - 1;
            double r = Math.Pow(3,2);
            double x = Math.Pow(px, 2);
            double y = Math.Pow(py, 2);
            if (r >= (x + y))
            {
                Console.WriteLine("Point is within circle");
            }
            else
            {
                Console.WriteLine("Point is outside of circle");
            }
            if (ix >= -1 && ix <= 5 && iy >= -1 && iy <= 1)
            {
                Console.WriteLine("Point is wihtin rectangule");
            }
            else
            {
                Console.WriteLine("Point is outside of rectangule");
            }
        }
    }
}
