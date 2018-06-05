using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Maximal_K_sum
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            if ((0<n && n<1025)&&(0<k && k<n+1))
            {
                int[] numbers = new int[n];
                int i = 0;
                int result = 0;

                while (i < n)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
                Array.Sort(numbers);
                while (k > 0)
                {
                    k--;
                    result = result + numbers[n - 1];
                    n--;
                }
                Console.WriteLine(result);
            }
        }
    }
}
