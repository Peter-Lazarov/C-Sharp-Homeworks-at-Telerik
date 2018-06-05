using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if ((0<n)&&(n<21))
            {
                int[] arr1 = new int[n];
                int[] arr2 = new int[n];
                bool result = true;
                for (int i = 0; i < n; i++)
                {
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    arr2[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (arr1[i]!=arr2[i])
                    {
                        result = false;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
