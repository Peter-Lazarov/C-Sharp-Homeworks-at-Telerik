using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static void Count(int n, string input, int x)
        {
            int[] all = new int[n];
            all = input.Split(' ').Select(int.Parse).ToArray();

            int appearance = 0;
            foreach (var item in all)
            {
                if (item == x)
                {
                    appearance++;
                }
            }
            Console.WriteLine(appearance);
        }
        static void Main()
        {
            Count(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
        }
    }
}
