using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int row = N;
            int plus = N - 1;
            if ((0 < N) && (N < 21))
            {
                do
                {
                    do
                    {
                        Console.Write(i);
                        i++;
                    }
                    while (i < (N + 1));
                    Console.WriteLine();
                    N = N + 1;
                    i = i - plus;
                }
                while (i < (row + 1));
            }
            else 
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
