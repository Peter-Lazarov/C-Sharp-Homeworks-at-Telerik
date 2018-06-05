using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Numbers_from_1_to_n
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type value for n, to print numbers from 1 to n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now I will print list of numbers between 1 and {0}", n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
