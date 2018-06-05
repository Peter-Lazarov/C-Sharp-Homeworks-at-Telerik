using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] All = new int[] { 5, 7, 10, 15, 20, 25, 29 };
            int k = 12;
            Array.Sort(All);

            int a = Array.BinarySearch(All, k);

            Console.WriteLine(a);
        }
    }
}
