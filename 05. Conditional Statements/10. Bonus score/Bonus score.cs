using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Bonus_score
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int num;
            bool result;
            result = Int32.TryParse(input, out num);
            if (result)
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Error value of your number is zero");
                        break;
                    case 1:
                        num = num * 10;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 2:
                        num = num * 10;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 3:
                        num = num * 10;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 4:
                        num = num * 100;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 5:
                        num = num * 100;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 6:
                        num = num * 100;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 7:
                        num = num * 1000;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 8:
                        num = num * 1000;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    case 9:
                        num = num * 1000;
                        Console.WriteLine("Yor score is {0}", num);
                        break;
                    default:
                        Console.WriteLine("Error occurred");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered string or decimal number, not integer");
            }
        }
    }
}
