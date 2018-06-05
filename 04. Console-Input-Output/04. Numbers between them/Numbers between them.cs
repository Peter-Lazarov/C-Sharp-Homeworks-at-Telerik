using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_between_them
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write number to start from");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write ending number");
            int b = Convert.ToInt32(Console.ReadLine());
            int reminder;
            int p = 0;

            int g = (b - a) + 1;
            for (int i = 1; i <= g; i++)
            {
                reminder = a % 5;
                if (reminder == 0)
                {
                    p = p + 1;
                }
                a = a + 1;
            }
            Console.WriteLine("Numbers count is {0}", p);
        }
    }
}
