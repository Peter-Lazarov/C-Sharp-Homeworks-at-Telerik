using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Hex_to_Decimal
{
    class Program
    {
        static void Main()
        {
            long dec = 0;
            string hex = Console.ReadLine();
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
            Console.WriteLine(dec);
        }
    }
}
