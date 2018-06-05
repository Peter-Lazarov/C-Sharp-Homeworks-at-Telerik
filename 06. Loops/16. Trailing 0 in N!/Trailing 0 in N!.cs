using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace _16.Trailing_0_in_N_
{
    class Program
    {
        static void Main()
        {
            //Factorial
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger factorial = 1;

            do
            {
                factorial = factorial * n;
                n = n - 1;
            } while (n > 1);
            //Zero count zone
            string digit = Convert.ToString(factorial);
            int a = digit.Length - 1;
            int zero = 0;
            int last = Convert.ToInt32(new string(digit.ElementAt(a),1));
            while (last == 0)
            {
		        zero++;
                a--;
                last = Convert.ToInt32(new string(digit.ElementAt(a), 1));
            }
            Console.WriteLine(zero);
        }
    }
}
