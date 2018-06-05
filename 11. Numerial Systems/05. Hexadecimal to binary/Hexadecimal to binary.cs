using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hexadecimal_to_binary
{
    class Program
    {
        static void Main()
        {
            long dec = 0;
            string hex = "1F4";
            int ncount = hex.Length;
            int i = ncount - 1;
            long p16 = 1;

            List<string> shex = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            while (i >= 0)
            {
                dec = dec + p16 * shex.IndexOf(Convert.ToString(hex.ElementAt(i)), 0);
                p16 = p16 * 16;
                i--;
            }

            long[] bin = new long[64];
            int a = 0;

            while (dec > 0)
            {
                bin[a] = dec % 2;
                dec /= 2;
                a++;
            }
            long[] result = new long[a];
            Array.Copy(bin, result, a);
            Array.Reverse(result);
            Console.WriteLine(String.Join("", result));
        }
    }
}
