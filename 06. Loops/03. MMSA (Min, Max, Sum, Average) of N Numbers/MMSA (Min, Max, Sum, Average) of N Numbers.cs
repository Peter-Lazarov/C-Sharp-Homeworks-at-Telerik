using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.MMSA__Min__Max__Sum__Average__of_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            List<double> numbers = new List<double>();
            double read = 0;

            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

            while (i < n)
            {
                read = Convert.ToDouble(Console.ReadLine());
                numbers.Add(read);
                i++;
            }
            Console.WriteLine("min=" + numbers.Min().ToString("N", nfi));
            Console.WriteLine("max=" + numbers.Max().ToString("N", nfi));
            Console.WriteLine("sun=" + numbers.Sum().ToString("N", nfi));
            Console.WriteLine("avg=" + numbers.Average().ToString("N", nfi));
        }
    }
}
