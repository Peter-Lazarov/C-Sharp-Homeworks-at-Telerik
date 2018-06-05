using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Maximal_sum
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            int i = 0;
            int j = 0;
            int[] num = {2,3,-6,-1,2,-1,6,4,-8,8};
            int sumCurrent = 0;
            int sumMax = 0;
            while (i<n)
            {
                //num[i] = Convert.ToInt32(Console.ReadLine());
                while (j < n)
                {
                    sumCurrent = num[j] + sumCurrent;
                    if (sumCurrent > sumMax)
                    {
                        sumMax = sumCurrent;
                    }
                    j++;
                   
                }
                i++;
                j = i;
                sumCurrent = 0;
            }
            Console.WriteLine(sumMax);
        }
    }
}
