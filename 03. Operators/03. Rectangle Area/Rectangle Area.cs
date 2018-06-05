using System;

namespace _03.Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Lenght of first side off rectangle");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lenght of secound side off rectangle");
            int b = Convert.ToInt32(Console.ReadLine());

            string s = Convert.ToString(a * b);
            Console.WriteLine("Rectangle area is " + s + " m2");
        }
    }
}
