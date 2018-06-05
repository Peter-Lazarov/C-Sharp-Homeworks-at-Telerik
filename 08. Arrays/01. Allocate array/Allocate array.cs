using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Allocate_array
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n>0) && (n<21))
            {
                int[] multiply = new int[n];
                for (int i = 0; i < n;i++)
                {
                    multiply[i] = i * 5;
                    Console.WriteLine(multiply[i]);
                }
            }
        }
    }
}
