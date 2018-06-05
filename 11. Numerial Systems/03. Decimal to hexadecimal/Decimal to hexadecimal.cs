using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static void Main()
        {
            long dec = Convert.ToInt64("19");
            int ostatak = 0;
            List<string> spisak = new List<string>();
            List<string> shex = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int i = 0;
            while (dec > 0)
            {
                ostatak = Convert.ToInt32(dec % 16);
                dec = dec / 16;
                i++;
                spisak.Add(shex.ElementAt(ostatak));
            }
            spisak.Reverse();
            foreach (var element in spisak)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
