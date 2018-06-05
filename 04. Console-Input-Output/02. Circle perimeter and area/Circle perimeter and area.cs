using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle_perimeter_and_area
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please type circle radius in meters");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The circle perimeter is {1} meters", r, r*2*3.14159);
            Console.WriteLine("The circle area {1} square meters", r, r*r*3.14159);
        }
    }
}
