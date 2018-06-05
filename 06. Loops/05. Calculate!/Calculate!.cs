using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Calculate_
{
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            decimal x = Convert.ToDecimal(Console.ReadLine());
            decimal xpow = 1;
            int i = 1;
            //Changing decimal separator to dot
            //and change decimal digits to five
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 5;

            decimal factorial = 1;
            decimal result = 1;       

            do
            {
                factorial = factorial * i;
                xpow = xpow * x;
                result = result + (factorial / xpow);
                i++;
            }while(i<(N+1));
            Console.WriteLine(result.ToString("N", nfi));
        }
    }
}
