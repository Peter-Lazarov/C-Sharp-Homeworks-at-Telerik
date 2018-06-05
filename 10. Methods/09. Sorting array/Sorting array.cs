using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {

        static int[] Data(int n, string input)
        {
            int[] all = new int[n];
            all = input.Split(' ').Select(int.Parse).ToArray();
            return all;
        }
        static int Max(int[] all)
        {
            int i = 2;
            int max = 0;

            while (i < all.Length)
            {
                if (max < all[i])
                {
                    max = all[i];
                }
                i++;
            }
            return max;
        }
        static void Sort(int[] all,string order = "a")
        {
            if (order == "a")
            {
                Array.Sort(all);
            }
            else if (order == "d")
            {
                Array.Sort(all);
                Array.Reverse(all);
            }
            Console.Write(String.Join(" ", all));
            Console.WriteLine();
        }
        static void Main()
        {
            Max(Data(7, "1 5 7 2 4 3 6"));
            Sort(Data(6, "36 10 1 34 28 38 31 27 30 20"), "a");
        }
    }
}
