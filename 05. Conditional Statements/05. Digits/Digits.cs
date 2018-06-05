using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Digits
{
    class Digits
    {
        static void Main()
        {
            Console.WriteLine("Please enter digit between 1 - 10");
            int digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    Console.WriteLine("1 - One");
                    break;
                case 2:
                    Console.WriteLine("2 - Two");
                    break;
                case 3:
                    Console.WriteLine("3 - Three");
                    break;
                case 4:
                    Console.WriteLine("4 - Four");
                    break;
                case 5:
                    Console.WriteLine("5 - Five");
                    break;
                case 6:
                    Console.WriteLine("6 - Six");
                    break;
                case 7:
                    Console.WriteLine("7 - Seven");
                    break;
                case 8:
                    Console.WriteLine("8 - Eight");
                    break;
                case 9:
                    Console.WriteLine("9 - Nine");
                    break;
                case 10:
                    Console.WriteLine("10 - Ten");
                    break;
                default:
                    Console.WriteLine("This digit is not in range or not a digit at all.");
                    break;
            }
        }
    }
}
