using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Bit_3_4_5_exchange_with_24__25__26
{
    class Program
    {
        static void Main()
        {
            // Extract bit value from integer
            Console.WriteLine("Type integer value");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input, 2));
            int p = 24;
            int a;
            int mask;
            int p2 = 3;
            int b;
            int result = input;

            for (int i = 1; i <= 3; i++)
            
            {
                mask = 1 << p;
                a = result & mask;
                a = a >> p;
                Console.WriteLine("Value of bit " + p + " is " + Convert.ToString(a, 2));

                // Change extracted bit value
                mask = 1 << p2;
                b = result & mask;
                b = b >> p2;
                Console.WriteLine("Value of bit " + p2 + " is " + Convert.ToString(b, 2));
                Console.WriteLine();

                if (b == 0 || (b == 1 && a == 1))
                {
                    b = a;
                    b = b << p2;
                    result = result | b;
                    Console.WriteLine("Temporary input value " + Convert.ToString(input, 2));
                    Console.WriteLine("Temporary value of bit " + p2 + " " + Convert.ToString(b, 2));
                    Console.WriteLine();
                }
                else if (b == 1 && a == 0)
                {
                    b = 1;
                    b = b << p2;
                    result = result ^ b;
                    Console.WriteLine("Temporary Input Value " + Convert.ToString(input, 2));
                    Console.WriteLine("Temporary value of bit " + p2 + " " + Convert.ToString(b, 2));
                    Console.WriteLine();
                }
                p = p + 1;
                p2 = p2 + 1;
            }
            Console.WriteLine("Input in bitwise system is  " + Convert.ToString(input, 2));
            Console.WriteLine("Result in bitwise system is " + Convert.ToString(result, 2));
            Console.WriteLine("Result in decimal system is " + result);
       }
    }
}
