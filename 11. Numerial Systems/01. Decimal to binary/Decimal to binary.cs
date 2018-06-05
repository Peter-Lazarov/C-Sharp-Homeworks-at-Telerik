using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static void Main()
        {
            long dec = 136;//1000000000000000000;
            long[] bin = new long[64];
            int i = 0;
            
            while (dec > 0)
            {
                bin[i] = dec % 2;
                dec /= 2;
                i++;
            }
            long[] result = new long[i];
            Array.Copy(bin, result, i);
            Array.Reverse(result);
            Console.WriteLine(String.Join("", result));
        }
    }
}