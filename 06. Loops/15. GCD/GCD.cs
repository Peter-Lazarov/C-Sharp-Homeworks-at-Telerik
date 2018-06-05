using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int a, b, t;
            string numbers = Console.ReadLine();
            List<int> All = numbers.Split(' ').Select(int.Parse).ToList();
            a = All.ElementAt(0);
            b = All.ElementAt(1);

            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            Console.WriteLine(a);
        }
    }
}
