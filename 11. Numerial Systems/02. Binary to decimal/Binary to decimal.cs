using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static void Main()
        {
            string input = "1000000";
            int length = input.Length - 1;
            long current = 0;
            long powered = 0;
            long result = 0;
            int p = 1;
            
            for (int i = length; i > -1; i--)
			{
                if (i == length)
                {
                    powered = 1;
                }
                else if (i == length - 1)
	            {
                    powered = 2;
	            }
                else if (i < length - 1)
                {
                    for (int j = 0; j < p; j++)
                    {
                        powered = powered * 2;
                    }
                    p++;
                }
                current = input[i] - '0';
                result = result + (current * powered);
                powered = 2;
			}
            Console.WriteLine(result);
        }
    }
}
