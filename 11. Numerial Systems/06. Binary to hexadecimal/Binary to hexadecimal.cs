using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static void Main()
        {
            string input = "10011";//"1000000";
            int length = input.Length - 1;
            long current = 0;
            long powered = 0;
            long result = 0;
            int p = 1;

            for (int i = length; i > -1; i--)
            {
                if (i == length)
                {
                    powered = 1;
                }
                else if (i == length - 1)
                {
                    powered = 2;
                }
                else if (i < length - 1)
                {
                    for (int j = 0; j < p; j++)
                    {
                        powered = powered * 2;
                    }
                    p++;
                }
                current = input[i] - '0';
                result = result + (current * powered);
                powered = 2;
            }

            int ostatak = 0;
            List<string> spisak = new List<string>();
            List<string> shex = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int a = 0;
            while (result > 0)
            {
                ostatak = Convert.ToInt32(result % 16);
                result = result / 16;
                a++;
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
