using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Quadratic_equation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("In quadratic equation ax2+bx+c=0, ");
            Console.WriteLine("please type values for a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("for b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("and for c");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = (Convert.ToDouble(Math.Pow(b, 2))) - (4 * a * c);
            Console.WriteLine("Value of D is {0}", d);
            double x1;
            double x2;
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots");
            }
            else if (d==0)
            {
                x1 = x1 = (-1 * b) / (2 * a);
                Console.WriteLine("The equation has one root x and is value is {0}", x1);
            }
            else if (d > 0)
            {
                x1 = (-1 * b + Convert.ToDouble(Math.Sqrt(d))) / (2 * a);
                Console.WriteLine("The first root of equation x1 is {0}", x1);
                x2 = (-1 * b - Convert.ToDouble(Math.Sqrt(d))) / (2 * a);
                Console.WriteLine("The secound root of equation x2 is {0}", x2);
            }
        }
    }
}
