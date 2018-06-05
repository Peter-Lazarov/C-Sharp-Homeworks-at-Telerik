using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Calculate_sum_0._001
{
    class Program
    {
        static void Main()
        {
            double sum = 0;
            double plus = 0;
            double a = 2;
            double minus = 0;
            double b = 3;
            Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5 + ...");
            Console.WriteLine("Please type how many steps to sum. For example 1 + 1/2 is two steps");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i = i + 2)
            {
                plus = plus + (1 / a);
                a = a + 2;
                Console.WriteLine("Step 2");
            }
            for (int i = 3; i <= n; i = i + 2)
            {
                minus = minus - (1 / b);
                b = b + 2;
                Console.WriteLine("Step 3");
            }
            sum = 1 + plus + minus;
            Console.WriteLine("{0:0.000}", sum);
        }
    }
}
