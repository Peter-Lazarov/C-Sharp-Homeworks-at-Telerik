using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Extract_bit_value_from_integer
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Type integer value");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type position p");
            int p = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << p;
            int a = input & mask;
            a = a >> p;
            Console.WriteLine("Value of searched bit is "+a);
        }
    }
}
