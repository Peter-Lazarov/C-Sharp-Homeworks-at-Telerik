using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_from_1_to_N_not_divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int number=1;
            
            while(number <= n)
            {
                if (((number % 3) != 0) && ((number % 7)!=0))
                {
                    Console.Write(number + " ");
                }
                number = number + 1;
            }
        }
    }
}
