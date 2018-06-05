using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class Program
    {
        static void Main()
        {
            string text = "Hi!";//"Te tova e teksta trebva da stae na literali?";
            ushort code = 0;
            string literals = "";
            for (int i = 0; i < text.Length; i++)
            {
                code = text[i];
                literals += string.Format("\\u{0:x4}", code);
            }
            Console.WriteLine(literals);
        }
    }
}
