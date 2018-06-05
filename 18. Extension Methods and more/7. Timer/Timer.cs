using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public static class Timer
    {
        public static void doSomething(int t)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(t * 1000);
                Console.WriteLine("I work {0} seconds", t);
            }
        }
        public delegate void delegateWork(int seconds);
    }
}
