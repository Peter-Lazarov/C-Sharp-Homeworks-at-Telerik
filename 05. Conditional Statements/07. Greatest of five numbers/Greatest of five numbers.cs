using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_of_five_numbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d, e;
            int greatest;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

            greatest = a;
            if(greatest < b)
            {
                greatest = b;
            }
            if (greatest < c)
            {
                greatest = c;
            }
            if (greatest < d)
            {
                greatest = d;
            }
            if (greatest < e)
            {
                greatest = e;
            }
            Console.WriteLine("The greatest number is {0}", greatest);
        }
    }
}
