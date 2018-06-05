using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.One_system_to_any_other
{
    class Program
    {
        static void Main()
        {
            //Description

            //Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.

            //Input

            //On the first line you will receive the number s
            //On the second line you will receive a number in base s - N
            //There will not be leading zeros
            //On the third line you will receive the number d
            //Output

            //Print N in base d
            //There should not be leading zeros
            //Use uppercase letters
            //Constraints

            //2 <= s, d <= 16
            //1 <= N <= 1018
            //Time limit: 0.1s
            //Memory limit: 16MB
            //Sample tests

            //Input	Output
            //13
            //16
            //9	21
            
            //Binary to decimal
            int system = 13;

            string input = "16";
            int length = input.Length - 1;
            long current = 0;
            long powered = 0;
            long dec = 0;
            int p = 1;

            for (int i = length; i > -1; i--)
            {
                if (i == length)
                {
                    powered = 1;
                }
                else if (i == length - 1)
                {
                    powered = system;
                }
                else if (i < length - 1)
                {
                    for (int j = 0; j < p; j++)
                    {
                        powered = powered * system;
                    }
                    p++;
                }
                current = input[i] - '0';
                dec = dec + (current * powered);
                powered = system;
            }
            Console.WriteLine(dec);

            ////Decimal to binary
            int system2 = 9;
            long[] bin = new long[64];
            int a = 0;

            while (dec > 0)
            {
                bin[a] = dec % system2;
                dec /= system2;
                a++;
            }
            long[] result = new long[a];
            Array.Copy(bin, result, a);
            Array.Reverse(result);
            Console.WriteLine(String.Join("", result));
        }
    }
}
