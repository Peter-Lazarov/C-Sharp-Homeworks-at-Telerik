using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_integers
{
    class Program
    {
        static void Main()
        {
            string given = "43 68 9 23 318";
            int[] all = given.Split(' ').Select(int.Parse).ToArray();

            int sum = all.Sum();
            Console.WriteLine(sum);
        }
    }
}
