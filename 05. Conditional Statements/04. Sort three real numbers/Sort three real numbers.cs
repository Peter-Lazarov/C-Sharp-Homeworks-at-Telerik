using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_three_real_numbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            int lowest = 0;
            int middle = 0;
            int biggest = 0;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            //For lowest number
            if (a < b)
            {
                if (a < c)
                {
                    lowest = a;
                }
                else
                {
                    lowest = c;
                }
            }
            else if (b < a)
            {
                if (b < c)
                {
                    lowest = b;
                }
                else
                {
                    lowest = c;
                }
            }

            //for biggest number
            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                }
                else
                {
                    biggest = c;
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    biggest = b;
                }
                else
                {
                    biggest = c;
                }
            }
            //For Middle number
            if ((lowest != a) && (biggest != a))
            {
                middle = a;
            }
            else if ((lowest != b) && (biggest != b))
            {
                middle = b;
            }
            else
            {
                middle = c;
            }
            Console.WriteLine("The numbers in descendig order are {0}, {1}, {2}", biggest, middle, lowest);
        }
    }
}
