using System;

namespace _05.Bit_of_given_integer
{
    class Program
    {
        static void Main()
        {
            //int a = 23;
            //Console.WriteLine(Convert.ToString(a, 2));
            //Console.WriteLine(Convert.ToString((a << 3), 2));
            //Console.WriteLine(Convert.ToString(a & (a << 3), 2));
            //Console.WriteLine(Convert.ToString(((a << 3) >> 8), 2));

            int number = 3;
            int mask = 1 << number;
            Console.WriteLine("Type integer to check third bit value is 1 or 0");
            int integer = int.Parse(Console.ReadLine());
            //moje i taka int integer = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Integer in bitwise system " + Convert.ToString(integer,2));
            Console.WriteLine("Mask value " + Convert.ToString(mask, 2));
            int result = integer & mask;
            Console.WriteLine("Result value " + Convert.ToString(result, 2));
            bool isThirdBit1 = result > 0;
            Console.WriteLine(isThirdBit1);
        }
    }
}
//Write a boolean expression for finding if 
//the bit 3 (counting from 0) of a given integer is 1 or 0.