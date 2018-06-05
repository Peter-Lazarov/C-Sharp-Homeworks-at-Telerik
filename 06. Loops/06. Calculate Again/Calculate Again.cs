using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace _06.Calculate_Again
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
                result = factorialN / factorialK;
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine("Your values for N and K are not in required constraints");
            }
        }
    }
}
