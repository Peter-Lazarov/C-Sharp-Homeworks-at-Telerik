using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Prime_Number
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type number to check for prime or composite");
            int input = Convert.ToInt32(Console.ReadLine());
            int a2 = input % 2;
            int b3 = input % 3;
            int c5 = input % 5;
            int d7 = input % 7;
            if (input == 2 || input == 3 || input == 5 || input == 7)
            {
                Console.WriteLine(input + " is a prime number");
            }
            else if (a2 != 0 && b3 != 0 && c5 != 0 && d7 != 0)
            {
                Console.WriteLine(input + " is a prime number");
            }
            else
            {
                Console.WriteLine("Your number " + input + " is composite");
            }
            Console.WriteLine("");

            Console.WriteLine("Another try, type number to check for prime or composite");
            input = Convert.ToInt32(Console.ReadLine());

            a2 = input % 2;
            b3 = input % 3;
            c5 = input % 5;
            d7 = input % 7;
            if (input == 2 || input == 3 || input == 5 || input == 7)
            {
                Console.WriteLine(input + " is a prime number");
            }
            else if (a2 != 0 && b3 != 0 && c5 != 0 && d7 != 0)
            {
                Console.WriteLine(input + " is a prime number");
            }
            else
            {
                Console.WriteLine("Your " + input + " number is composite");
            }
        }
    }
}
