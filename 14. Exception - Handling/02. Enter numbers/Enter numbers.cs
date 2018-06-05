using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_numbers
{
    class Program
    {
        static string result = "";
        static bool error = false;
        static void ReadNumber(int start, int end,string[] input)
        {
            string separate = " < ";
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int num = Int32.Parse(input[i]);
                    end = Int32.Parse(input[i + 1]);
                    if ((start < num) && (num < end))
                    {
                        if (end == 100)
                        {
                            separate = "";
                        }
                        result += num.ToString() + separate;
                        start = num;
                    }
                    else
                    {
                        error = true;
                    }
                }
                catch (FormatException)
                {
                    error = true;
                }
                catch (Exception)
                {
                    error = true;
                }
            }
        }
        static void Main()
        {
            string[] input = new string[11];
            input[10] = "100";
            for (int i = 0; i < 10; i++)
            {
                input[i] = Console.ReadLine();
            }
            //string[] input = { "2", "7", "6", "29", "46", "47", "60", "70", "89", "98", "100" };
            ReadNumber(1, 100, input);
            if (error)
            {
                Console.WriteLine("Exception");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
