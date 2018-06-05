using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace _08.Catalan_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 2;
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            decimal result = 1;
            while (k < (n+1))
            {
                numerator = numerator * (n + k);
                denominator = denominator * k;
                k++;
            }
            Console.WriteLine(BigInteger.Divide(numerator, denominator));
        }
    }
}
