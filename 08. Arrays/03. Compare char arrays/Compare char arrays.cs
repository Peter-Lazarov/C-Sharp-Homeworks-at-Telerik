using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main()
        {
            char[] symbols1 = Console.ReadLine().ToCharArray();
            char[] symbols2 = Console.ReadLine().ToCharArray();

            if (symbols1.Length > symbols2.Length)
            {
                Console.WriteLine(">");
            }
            else if (symbols1.Length < symbols2.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
