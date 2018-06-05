using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exchange_value
{
    class Program
    {
        static void Main()
        {
            int one = Convert.ToInt32(Console.ReadLine());
            int two = Convert.ToInt32(Console.ReadLine());
            int temp;

            if (one > two)
            {
                temp = two;
                two = one;
                one = temp;
                Console.WriteLine("The first int is greater than secound and the values is exchanged");
                Console.WriteLine("The first is {0}", one);
                Console.WriteLine("The secound is {0}", two);
            }
            else if (one == two)
            {
                Console.WriteLine("The ints are equal");
            }
            else
            {
                Console.WriteLine("The secound int is greater than first and the values are not exchanged");
            }
        }
    }
}
