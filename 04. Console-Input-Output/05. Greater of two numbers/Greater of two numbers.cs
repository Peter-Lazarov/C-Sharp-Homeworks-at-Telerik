using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Greater_of_two_numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type one integer to check");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type another integer to check");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Math.Max(a, b);
            Console.WriteLine("The greater integer is {0}", c);
        }
    }
}
