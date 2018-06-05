using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program
    {
        static void NeighbourhoodFirst(int n, string digits)
        {
            int[] all = new int[n];
            all = digits.Split().Select(int.Parse).ToArray();

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (i != 0 && i != n - 1)
                {
                    if ((all[i] > all[i - 1]) && (all[i] > all[i + 1]))
                    {
                        index = i;
                        i = n;
                    }
                }
            }
            Console.WriteLine(index);
        }
        static void Main()
        {
            NeighbourhoodFirst(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
        }
    }
}
