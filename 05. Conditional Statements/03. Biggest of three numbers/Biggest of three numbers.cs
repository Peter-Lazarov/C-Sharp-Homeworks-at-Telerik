using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Biggest_of_three_numbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Biggest number is {0}", a);
                }
                else
                {
                    Console.WriteLine("Biggest number is {0}", c);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest number is {0}", b);
                }
                else
                {
                    Console.WriteLine("Biggest number is {0}", c);
                }
            }
        }
    }
}
