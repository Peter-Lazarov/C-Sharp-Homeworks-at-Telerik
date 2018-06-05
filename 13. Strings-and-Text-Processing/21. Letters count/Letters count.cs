using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Letters_count
{
    class Program
    {
        static void Main()
        {
            string text = "This is some text for letters.";
            ushort ascii = 0;
            ushort[] repeating = new ushort[255];
            for (int i = 0; i < text.Length; i++)
            {
                ascii = text[i];
                repeating[ascii]++;
            }
            //A - 65 ... Z - 90
            //a - 97 ... z - 122
            for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar(i + 65) + " ");
                Console.Write(repeating[i + 65]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar(i + 97) + " ");
                Console.Write(repeating[i + 97]);
                Console.WriteLine();
            }
        }
    }
}