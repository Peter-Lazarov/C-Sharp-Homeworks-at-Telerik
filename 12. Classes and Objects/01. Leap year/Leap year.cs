using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Leap_year
{
    class Program
    {
        static void Main()
        {
            int year = 2000;

            bool leap = DateTime.IsLeapYear(year);
            if (leap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
