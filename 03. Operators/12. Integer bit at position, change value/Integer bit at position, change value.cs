using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_bit_at_position__change_value
{
    class Program
    {
        static void Main()
        {
            // Extract bit value from integer
            Console.WriteLine("Type integer value");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input, 2));
            Console.WriteLine("Type position p");
            int p = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << p;
            Console.WriteLine(Convert.ToString(mask, 2));
            int a = input & mask;
            a = a >> p;
            Console.WriteLine("Value of searched bit is " + a);

            // Change extracted bit value
            Console.WriteLine("Type new value for desired bit");
            int v = Convert.ToInt32(Console.ReadLine());
            int b;
            int result=0;
            if (a == 0 || (a == 1 && v == 1))
            {
                b = v;
                b = b << p;
                result = input | b;
            }
            else if (a == 1 && v == 0)
            {
                b = 1;
                b = b << p;
                result = input ^ b;
            }
            Console.WriteLine(Convert.ToString(result, 2));
            Console.WriteLine(result);
        }
    }
}
