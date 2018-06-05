using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_equation
{
    class Program
    {
        static void Main()
        {
            int a, b, c, D, x1, x2;

            Console.WriteLine("Please enter value for coeficient a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value for coeficient b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value for coeficient c");
            c = Convert.ToInt32(Console.ReadLine());

            D = Convert.ToInt32(Math.Pow(b, 2)) - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b + Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
                x2 = (-b - Convert.ToInt32(Math.Sqrt(D))) / (2 * a);
                Console.WriteLine("The value of discriminant D is {0}", D);
                Console.WriteLine("The root of equation is x1 = {0} and x2 = {1}.", x1, x2);
            }
            else if (D == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine("The one root of equation is x = {0}.", x1);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}
