using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_change
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            a = Math.Sign(a);
            b = Math.Sign(b);
            c = Math.Sign(c);
            
            if (a+b+c == 3 || a+b+c == -1 )
            {
                Console.WriteLine("The sign of product is +");
            }
            else if (a+b+c == 1 || a+b+c == -3)
            {
                Console.WriteLine("The sign of product is -");
            }
            else if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("The value of product is 0");
            }
        }
    }
}
