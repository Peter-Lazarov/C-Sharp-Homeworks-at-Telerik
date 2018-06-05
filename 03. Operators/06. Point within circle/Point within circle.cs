using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_within_circle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type x coordinate of point");
            int ix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type y coordinate of point");
            int iy = Convert.ToInt32(Console.ReadLine());
            double r = Math.Pow(5, 2);
            double x;
            double y;
            
            x = Math.Pow(Convert.ToDouble(ix), 2);
            y = Math.Pow(Convert.ToDouble(iy), 2);
            
            if (x + y <= r)
            {
                Console.WriteLine("Yes, point is within circle K(0,0)5");
            }
            else
            {
                Console.WriteLine("No, point isn't within circle K(0,0)5");
            }
        }
    }
}
