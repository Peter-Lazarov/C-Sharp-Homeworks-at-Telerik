using System;

namespace _03.Operators
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int del = 2;
            long r = n % del;
            Console.WriteLine(r);
            if (r != 0)
            {
                Console.WriteLine("Given Number is Odd");
            }
            else if (r == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
        }
    }
}
