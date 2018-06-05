using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Read_3_integer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type 3 integer numbers to calculate their sum");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of three numbers is {0}", a + b + c);
        }
    }
}
