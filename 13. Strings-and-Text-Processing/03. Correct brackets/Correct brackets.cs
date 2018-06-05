using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main()
        {
            string expresion = ")(a+b))";//"((a+b)/5-d)";//"(2 + 3) * (2 - 5)";
            int bracket = 0;
            string validate = "";

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i] == '(')
                {
                    bracket++;
                }
                else if (expresion[i] == ')')
                {
                    bracket--;
                }
            }

            if (bracket < 0)
            {
                validate = "Incorrect";
            }
            else if (bracket == 0)
            {
                validate = "Correct";
            }

            Console.WriteLine(validate);
        }
    }
}
