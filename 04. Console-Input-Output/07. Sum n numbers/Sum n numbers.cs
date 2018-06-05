using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_n_numbers
{
    class Program
    {
        static void Main()
        {
            int n;
            int sum = 0;
            //Console.WriteLine("Please type number n");
            //while (true)
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    sum = sum + n;
            //    Console.WriteLine("Sum of numbers n is {0}", sum);
            //}

            while (true)
            {
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum + n;
                Console.WriteLine("Sum of numbers n is {0}", sum);
            }
        }
    }
}
