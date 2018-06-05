using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fibonacci_sequence
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long a = 0;
            long b = 1;
            long c = 0;
            Console.WriteLine("The Fibonacci sequence is");
            if (n > 0)
            {
                Console.WriteLine(a);
                if (n > 1)
                {
                    Console.WriteLine(b);
                    if (n > 2)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            c = a + b;
                            Console.WriteLine(c);
                            a = b;
                            b = c;
                        }
                    }
                }
                
            }
        }
    }
}
