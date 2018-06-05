using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Find_sum_in_array
{
    class Program
    {
        static void Main()
        {
            int[] All = { 4, 3, 1, 4, 2, 5, 8 };
            int[] Small = new int[All.Length];
            int i = 0;
            int j = 0;
            int stepstart = 0;
            int stepend = 0;
            int S = 11;

            while (j < All.Length)
	        {
                Array.Clear(Small, 0, Small.Length);
                while (i < All.Length)
                {
                    Small[i] = All[i];
                    if (Small.Sum() == S)
                    {
                        stepstart = j;
                        stepend = i;
                        i = All.Length;
                        j = All.Length;
                    }
                    i++;
                }
                j++;
                i = j;
	        }
            Console.Write("{0}", Small[stepstart]);
            stepstart++;
            while (stepstart < stepend + 1)
            {
                Console.Write(", ");
                Console.Write("{0}",Small[stepstart]);
                stepstart++;
            }
            Console.WriteLine();
        }
    }
}
