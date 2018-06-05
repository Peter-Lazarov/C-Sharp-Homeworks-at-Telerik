using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    class lecture
    {
        //static void Main()
        //{
        //    trytwo(5, 7);
        //}
        //static void trytwo(int one, int two)
        //{
        //    one = one + two + 20;
        //    Console.WriteLine(one);
        //}

        //Just try for method and find misstake of ;
        //static void Main()
        //{
        //    product(2, 5, 4);
        //}
        //static void product(int one, int two, int three)
        //{
        //    one = 2;
        //    two = 3;
        //    one = one * two;
        //    Console.WriteLine(one);
        //}

        //// Product of three numbers
        //static void Main()
        //{
        //    product(2, 5, 7);
        //    product(1, 2, 3);
        //    product(5, 6, 7);
        //}
        //static void product(int one, int two, int three)
        //{
        //    one = one * two * three;
        //    Console.WriteLine(one);
        //}

        //// Month period
        //static void Main()
        //{
        //    Period(3, 6);
        //}
        //static void Monthperiod(int month)
        //{
        //    string[] allmonths = 
        //    {
        //        "Jan", "Feb", "Mar", "Apr",
        //        "May", "Jun", "Jul", "Aug",
        //        "Sep", "Oct", "Nov", "Dec"
        //    };
        //    Console.Write(allmonths[month - 1]);
        //}
        //static void Period(int begin, int end)
        //{
        //    int result = end - begin;
        //    if (result < 0)
        //    {
        //        result += 12;
        //    }
        //    Console.Write("From ");
        //    Monthperiod(begin);
        //    Console.Write(" to ");
        //    Monthperiod(end);
        //    Console.Write(" have {0} months.", result);
        //}

        //// Pyramids of numbers
        //static void Main()
        //{
        //    pyramid(6);
        //}
        //static void pyramid(int n)
        //{
        //    //numbers go up
        //    for (int i = 1; i < n + 1; i++)
        //    {
        //        core(i);
        //    }

        //    //numbers go down
        //    for (int i = n - 1; i > 0; i--)
        //    {
        //        core(i);
        //    }
        //}
        //static void core(int a)
        //{
        //    for (int j = 1; j < a + 1; j++)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}

        //// Returning method
        //static int ReturningMetod(int one, int two)
        //{
        //    return one + two;
        //}
        //static void Main()
        //{
        //    Console.WriteLine(ReturningMetod(1, 5));
        //}
        
        //// Variable for all space
        //static int a = 5;

        //static void ReturningMetod()
        //{
        //    a = a + 10;
        //    a = a + 5;
        //}
        //static void Main()
        //{
        //    ReturningMetod();
        //    Console.WriteLine(a);
        //}

        static void Main()
        {
            int a = 3;
            int b = a / 10;
        }
    }
}
