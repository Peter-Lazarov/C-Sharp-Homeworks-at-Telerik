using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main()
        {
            int i = 0;
            int j = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int [n];
            int iMin = 0;
            int temp = 0;

            for (int b = 0; b < n; b++)
            {
                a[b] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (j = 0; j < n-1; j++)
            {
                iMin = j;
                for (i = j+1; i < n; i++)
                {
                    if (a[i]<a[iMin])
                    {
                        iMin = i;
                    }
                }
                if (iMin != j)
                {
                    temp = a[j];
                    a[j] = a[iMin];
                    a[iMin] = temp;
                    
                }
            }
            for (int c= 0; c < n; c++)
            {
                Console.WriteLine(a[c]);
            }
        }
    }
}
