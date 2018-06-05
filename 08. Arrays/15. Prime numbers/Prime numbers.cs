using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Prime_numbers
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] prime = new bool[n+1];
            prime = Enumerable.Repeat(true, n+1).ToArray();
            prime[0] = false;
            prime[1] = false;

            int p = 0;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (prime[i] == true)
                {
                    for (int j = i * i; j <= n; j = i * i + p * i)
                    {
                        prime[j] = false;
                        p++;
                    }
                    p = 0;
                }
            }
            // Print all prime number to n
            //for (int g = 0; g < n+1; g++)
            //{
            //    if (prime[g] == true)
            //    {
            //        Console.WriteLine(g);
            //    }
            //}
            Console.WriteLine(Array.LastIndexOf(prime, true)); ;
        }
    }
}
