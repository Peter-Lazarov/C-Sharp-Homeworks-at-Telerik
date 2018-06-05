using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class Program
    {
        static void Main()
        {
            string text = "-=StringOfLength20=-";//"hello";
            StringBuilder working = new StringBuilder(20);
            int repeat = 20 - text.Length;
            string result = "";
        
            working.Append(text);
            if (text.Length < 20)
            {
                working.Append('*', repeat);
            }
            result = working.ToString();
            Console.WriteLine(result);
        }
    }
}
