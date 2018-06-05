using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Integer_v_at_position_p
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type searched integer value");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Integer in bitwise system " + Convert.ToString(input, 2));

            Console.WriteLine("Type searched position p");
            int number = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << number;
            
            int result = input & mask;
            bool a = result > 0;
            Console.WriteLine("Is it value of bit 1? "+ a);
        }
    }
}
