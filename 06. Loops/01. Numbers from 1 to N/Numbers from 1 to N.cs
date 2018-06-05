using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_from_1_to_N
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (sum < n)
            {
                sum = sum + 1;
                Console.Write(sum + " ");
            }
        }
    }
}
