using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Random_numbers
{
    class Program
    {
        static void RandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(100,200));
            }
        }
        static void Main()
        {
            RandomNumbers();
        }
    }
}
