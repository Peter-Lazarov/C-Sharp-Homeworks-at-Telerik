using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main()
        {
            string text = "sample";//"Pesho"//Console.ReadLine();;
            
            StringBuilder operate = new StringBuilder(text.Length);
            string result = "";
            for (int i = text.Length - 1; 0 <= i; i--)
            {
                operate.Append(text[i]);
            }
            result = operate.ToString();
            Console.WriteLine(result);
        }
    }
}
