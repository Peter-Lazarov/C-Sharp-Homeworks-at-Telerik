using System;

namespace _04.Integer_digit_check
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter number to check 3rd digit");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit = (number / 100) % 10;
            if (digit == 7)
            {
                Console.WriteLine("Congractulation your number have digit 7 in it.");
            }
            else
            {
                Console.WriteLine("In this number doesn't have 7 on third position");
            }
        }
    }
}
