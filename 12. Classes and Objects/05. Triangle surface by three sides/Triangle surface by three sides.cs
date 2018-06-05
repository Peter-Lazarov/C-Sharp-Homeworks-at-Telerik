using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static void Main()
        {
            double a = 11;
            double b = 12;
            double c = 13;

            double p = (a + b + c)/2;

            double surface = p*(p - a) * (p - b) * (p - c);
            surface = Math.Sqrt(surface);
            Console.WriteLine("{0:0.00}",surface);
        }
    }
}
