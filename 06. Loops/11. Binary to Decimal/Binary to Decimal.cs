using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin = "11111111111111111111111111111111";
            int bitcount = bin.Length;
            long dec = 0;
            long a = 1;
            int i = (bitcount - 1);
            int b = 0;

            while (bitcount>0)
            {
                b = Convert.ToInt32(Char.GetNumericValue(bin[i]));
                dec = (a * b) + dec;
                a = a * 2;
                i--;
                bitcount--;
            }
            Console.WriteLine(dec);
        }
    }
}
