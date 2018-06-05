using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.Calculate_3
{
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorial3 = 1;
            int difference = 0;

            BigInteger result = 1;
            if ((K > 1) && (N > K) && (N < 100))
            {
                do
                {
                    factorialN = factorialN * i;
                    if (i == K)
                    {
                        factorialK = factorialN;
                    }
                    i++;
                } while (i < (N + 1));
                difference = N - K;
                i = 1;
                do
                {
                    factorial3 = factorial3 * i;
                    i++;
                } while (i < (difference + 1));
                result = factorialN / (factorialK * factorial3) ;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Your values for N and K are not in required constraints");
            }
        }
    }
}
