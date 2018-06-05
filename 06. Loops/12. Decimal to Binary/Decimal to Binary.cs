using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main()
        {
            long dec = Convert.ToInt32(Console.ReadLine());
            long d;
            List<string> result = new List<string>();
            while ((dec+1) > 1)
            {
                d = dec % 2;
                dec = dec / 2;
                result.Add(Convert.ToString(d));
            }
            result.Reverse();
            foreach (var element in result)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
