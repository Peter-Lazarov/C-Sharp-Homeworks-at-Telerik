using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static void Neighbourhood(int n, string digits)
        {
            int[] all = new int[n];
            all = digits.Split().Select(int.Parse).ToArray();

            int greater = 0;

            for (int i = 0; i < n; i++)
            {
                if (i != 0 && i != n - 1)
                {
                    if ((all[i] > all[i - 1]) && (all[i] > all[i + 1]))
                    {
                        greater++;
                    }
                }
            }
            Console.WriteLine(greater);
        }
        static void Main()
        {
            Neighbourhood(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
        }
    }
}
