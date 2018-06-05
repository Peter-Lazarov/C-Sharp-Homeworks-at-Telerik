using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static void Main()
        {
            double side = 23.2;
            double altitude = 5;

            double surface = (side * altitude) / 2;
            Math.Round(surface, 2);
            Console.WriteLine("{0:0.00}", surface); //Print 58,00 insted of 58
        }
    }
}
