using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Frequent_number
{
    class Program
    {
        static void Main()
        {
            int n = 13;
            int[] num = {4,1,1,4,2,3,4,4,1,2,4,9,3};
            int i = 1;
            Array.Sort(num);
            int current = num[0];
            int times = 1;
            int max = 0;
            int maxrepeated = 0;

            while (i<n)
            {
                if (num[i] == current)
                {
                    times++;
                    if (max < times)
                    {
                        max = times;
                        maxrepeated = num[i];
                    }
                }
                else if (num[i] != current)
                {
                    times = 1;
                }
                current = num[i];
                i++;
            }
            Console.WriteLine("{0} ({1} times)", maxrepeated, max);
        }
    }
}
