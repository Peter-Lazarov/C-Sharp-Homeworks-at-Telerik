using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class Program
    {
        static void Main()
        {
            //http://telerikacademy.com/Forum/Questions/193624/%D0%92%D1%8A%D0%BF%D1%80%D0%BE%D1%81-%D0%BE%D1%82%D0%BD%D0%BE%D1%81%D0%BD%D0%BE-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0-08-Number-as-array
            string input = "4 5"; // Console.ReadLine();

            int aone = (int)Char.GetNumericValue(input[0]);
            int atwo = (int)Char.GetNumericValue(input[2]);
            int[] arrayone = new int[aone];
            int[] arraytwo = new int[atwo];

            input = "1 4 6 7"; // Console.ReadLine();
            arrayone = input.Split(' ').Select(int.Parse).ToArray();
            input = "2 5 7 9 3"; // Console.ReadLine();
            arraytwo = input.Split(' ').Select(int.Parse).ToArray();

            int first = 0;
            int secound = 0;
            int ten = 1;
            int result = 0;
            for (int i = 0; i < aone; i++)
            {
                first = first + arrayone[i] * ten;
                ten *= 10;
            }
            ten = 1;
            for (int i = 0; i < atwo; i++)
            {
                secound = secound + arraytwo[i] * ten;
                ten *= 10;
            }
            ten = 10;
            result = first + secound;
            int[] arrayresult = new int[result.ToString().Length];
            //47393
            for (int i = result.ToString().Length - 1; -1 < i; i--)
            {
                if (i == result.ToString().Length - 1)
                {
                    arrayresult[i] = result % ten;
                }
                else
                {
                    arrayresult[i] = (result % ten) / (ten / 10);
                }
                ten *= 10;                
            }

            Console.WriteLine(string.Join(" ", arrayresult));
        }
    }
}
