using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Encode___decode
{
    class Program
    {
        static void Main()
        {
            //Example from Nakov's book page 499
            string text = "Nakov";
            string cipher = "ab";
            ushort cipherCode = 0;
            ushort textCode = 0;
            int[] crypted = new int[text.Length];
            string result = "";

            for (int index = 0; index < text.Length; index++)
            {
                cipherCode = cipher[index % cipher.Length];
                textCode = text[index];
                crypted[index] = cipherCode ^ textCode;
                //Console.Write("\\u{0:x4}", result);
            }
            Console.WriteLine(string.Join(" ",crypted));

            for (int index = 0; index < text.Length; index++)
            {
                cipherCode = cipher[index % cipher.Length];
                result += Convert.ToChar(cipherCode ^ crypted[index]);
            }
            Console.WriteLine(result);
        }
    }
}
