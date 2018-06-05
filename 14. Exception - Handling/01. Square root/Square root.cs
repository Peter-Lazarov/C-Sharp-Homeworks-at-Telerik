using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_root
{
    class Program
    {
        static void Main()
        {
            string input = "17";
            double num = 0;
            try
            {
                num = double.Parse(input);
                if (num < 0)
                {
                    throw new FormatException();
                }
                num = Math.Sqrt(num);
                Console.WriteLine("{0:0.000}", num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
