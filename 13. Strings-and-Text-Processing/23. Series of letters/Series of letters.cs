using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder change = new StringBuilder();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1 || input[i] != input[i + 1])
	            {
                    change.Append(input[i]);
	            }
            }
            result = change.ToString();
        }
    }
}
