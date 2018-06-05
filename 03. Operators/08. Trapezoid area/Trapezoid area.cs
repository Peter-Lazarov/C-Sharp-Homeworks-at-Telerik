using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trapezoid_area
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type your lenght of side a, b and height h of trapezoid");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            int area = (a+b)/2*h;
            Console.WriteLine("The area of trapezoid is "+ area + "m2");
        }
    }
}
