using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Subset_with_sum_S
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[] numbers = { 1, 2, 3, 4}; //new int[n];
            int s = 11;
            int moment = 0;

            leveldown(n, numbers, moment, s, 0, 0);
        }
        static void leveldown(int n, int[] numbers, int moment, int s, int i, int j)
        {
            while (i < n)
            {
                while (j < n)
                {
                    if (j == n)
                    {
                        return;
                    }
                    moment = moment + numbers[j];
                    Console.WriteLine(moment);
                    if ((i < n - 2) && (j == n - 1))
                    {
                        moment = moment - numbers[j];
                        moment = moment - numbers[j - 1];
                        moment = moment + numbers[j];
                        Console.WriteLine(moment);
                    }
                    if (moment == s)
                    {
                        Console.WriteLine("Yes");
                    }
                    j++;
                    //leveldown(n, numbers, moment, s, i, j);
                }
                i++;
                j = i;
                moment = 0;
                Console.WriteLine("time i");
            }
        }
    }
}
