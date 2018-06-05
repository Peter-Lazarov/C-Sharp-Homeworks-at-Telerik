using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static void GetMax(string input, int count = 3)
        {
            int[] digits = new int[count];
            digits = input.Split(' ').Select(int.Parse).ToArray();

            int max = digits[0];
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (max < digits[i + 1])
                {
                    max = digits[i + 1];
                }
            }
            Console.WriteLine(max);
        }
        static void Main()
        {
            GetMax(Console.ReadLine(),3);
        }
    }
}
