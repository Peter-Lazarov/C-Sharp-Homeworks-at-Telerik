using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Numbers_with_names
{
    class Program
    {
        static void Main()
        {
            
            string input = Console.ReadLine();
            int lenght = input.Length;
            Console.Write("{0} - ", input);
            char a;
            int char1 = 0;
            int char2 = 0;
            int char3 = 0;

            if (lenght == 3)
            {
                a = input[0];
                char1 = Convert.ToInt32(Char.GetNumericValue(a));
                a = input[1];
                char2 = Convert.ToInt32(Char.GetNumericValue(a));
                a = input[2];
                char3 = Convert.ToInt32(Char.GetNumericValue(a));
            }
            else if (lenght == 2)
            {
                a = input[0];
                char2 = Convert.ToInt32(Char.GetNumericValue(a));
                a = input[1];
                char3 = Convert.ToInt32(Char.GetNumericValue(a));
            }
            else if (lenght == 1)
            {
                a = input[0];
                char3 = Convert.ToInt32(Char.GetNumericValue(a));
            }

            if (lenght == 3)
            {
                switch (char1)
                {
                    case 1:
                        Console.Write("One hundred");
                        break;
                    case 2:
                        Console.Write("Two hundred");
                        break;
                    case 3:
                        Console.Write("Three hundred");
                        break;
                    case 4:
                        Console.Write("Four hundred");
                        break;
                    case 5:
                        Console.Write("Five hundred");
                        break;
                    case 6:
                        Console.Write("Six hundred");
                        break;
                    case 7:
                        Console.Write("Seven hundred");
                        break;
                    case 8:
                        Console.Write("Eight hundred");
                        break;
                    case 9:
                        Console.Write("Nine hundred");
                        break;
                    default:
                        Console.Write("You enter wrong symbol");
                        break;
                }
                lenght = lenght - 1;
                if (char2 == 0)
                {
                    if (char3 == 0)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.Write(" and ");
            }
            if (lenght == 2)
            {
                switch (char2)
                {
                    case 0:
                        break;
                    case 1:
                        switch (char3)
                        {
                            case 0:
                                Console.Write("ten");
                                break;
                            case 1:
                                Console.Write("eleven");
                                break;
                            case 2:
                                Console.Write("twelve");
                                break;
                            case 3:
                                Console.Write("thirteen");
                                break;
                            case 4:
                                Console.Write("fourteen");
                                break;
                            case 5:
                                Console.Write("fifthteen");
                                break;
                            case 6:
                                Console.Write("sixteen");
                                break;
                            case 7:
                                Console.Write("seventeen");
                                break;
                            case 8:
                                Console.Write("eighteen");
                                break;
                            case 9:
                                Console.Write("nineteen");
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine();
                        return;
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirty");
                        break;
                    case 4:
                        Console.Write("fourty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("ninety");
                        break;
                    default:
                        Console.Write("You enter wrong symbol");
                        break;
                }
                if (char2 != 0)
                {
                    Console.Write(" ");
                }
                if (char3 == 0)
                {
                    Console.WriteLine();
                    return;
                }
                lenght = lenght - 1;
            }
            if (lenght == 1)
            {
                switch (char3)
                {
                    case 0:
                        Console.Write("zero");
                        break;
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                    default:
                        break;
                }
            }
        Console.WriteLine();
        }
    }
}