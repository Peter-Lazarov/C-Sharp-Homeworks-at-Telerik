using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int m = 0;
            string input = "";
            int[] line = new int[2];
            int i = 0;
            int j = 0;

            input = Console.ReadLine();
            line = input.Split(' ').Select(int.Parse).ToArray();
            n = line[0];
            m = line[1];

            int[,] all = new int[n, m];

            for (i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                line = input.Split(' ').Select(int.Parse).ToArray();
                for (j = 0; j < m; j++)
                {
                    all[i, j] = line[j];
                }
            }

            n = n - 1;
            m = m - 1;

            i = 0;
            j = 0;
            int a = 0;
            int b = 0;
            int ie = 0;
            int je = 0;
            int sum = 0;
            int maxsum = 0;

            while ((i < n + 1) && (a < n - 1))
            {
                while ((j < m + 1) && (b < m - 1))
                {
                    ie = a + 3;
                    je = b + 3;
                    for (i = 0; i + a < ie; i++)
                    {
                        for (j = 0; j + b < je; j++)
                        {
                            sum = sum + all[i + a, j + b];
                        }
                    }
                    i = 0;
                    j = 0;
                    b++;
                    if ((sum > maxsum) && (sum != 0))
                    {
                        maxsum = sum;
                    }
                    sum = 0;
                }
                a++;
                b = 0;
            }
            Console.WriteLine(maxsum);
        }
    }
}
