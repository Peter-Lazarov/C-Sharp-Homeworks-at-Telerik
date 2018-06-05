using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if ((3 < N) && (N < 50))
            {
                long odd = 1;
                long even = 1;
                int i = 0;
                //string numbers = Console.ReadLine();
                string numbers = "4 3 2 5 2";
                List<int> All = numbers.Split(' ').Select(int.Parse).ToList();
                foreach (var element in All)
                {
                    if ((i % 2 == 0))
                    {
                        odd = odd * All.ElementAt(i);
                    }
                    else
                    {
                        even = even * All.ElementAt(i);
                    }
                    i++;
                }
                if (even == odd)
                {
                    Console.WriteLine("yes PRODUCT_VALUE {0}", even);
                }
                else
                {
                    Console.WriteLine("no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE {0} {1}", odd, even);
                }
            }
            else 
            {
                Console.WriteLine("Your input is outside of constraints");
            }
            
        }
    }
}
