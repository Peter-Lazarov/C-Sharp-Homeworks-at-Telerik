using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Format_number
{
    class Program
    {
        static void Main()
        {
            //http://www.csharp-examples.net/align-string-with-spaces/
            Console.WriteLine("Just an a example");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("First Name | Last Name  |   Age");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Bill", "Gates", 51));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Edna", "Parker", 114));
            Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", "Johnny", "Depp", 44));
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            int number = 15;

            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:d}", number);
            Console.WriteLine("{0,15:X4}", number);
            Console.WriteLine("{0,15:x4}", number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:p}", number);
            Console.WriteLine("{0,15:E}", number);
            Console.WriteLine("{0,15:e}", number);
        }
    }
}
