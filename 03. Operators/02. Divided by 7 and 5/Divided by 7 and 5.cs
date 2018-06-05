using System;

namespace _02.Divided_by_7_and_5
{
    class Program
    {
        static void Main()
        {
            int r = Convert.ToInt32(Console.ReadLine());
            int s = r % 7;
            int f = r % 5;

            bool sa = false;
            bool fa = false;

            if (s == 0)
            {
                sa = true;
            }
            if (f == 0)
            {
                fa = true;
            }
            if (sa && fa)
            {
                Console.WriteLine("Bravo your number has divided by 5 and 7 at same time");
            }
            else 
            {
                if (!sa && !fa)
                {
                    Console.WriteLine("Number doesn't divide by 5 and 7");
                }
                else
                {
                    if (sa)
                    {
                        Console.WriteLine("Not divided by 5");
                    }
                    else if (fa)
                    {
                        Console.WriteLine("Not divided by 7");
                    }
                }
            }
        }
    }
}
