using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


namespace _07.Exam_1
{
    class Program
    {
        static void Main()
        {   
            //Accept dot as decimal symbol
            CultureInfo ci = new CultureInfo("en-US", true);
            Thread.CurrentThread.CurrentCulture = ci;

            //Changing decimal separator to dot
            //and change decimal digits to five
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.NumberDecimalDigits = 2;
            int N = Convert.ToInt32(Console.ReadLine());
            int S = Convert.ToInt32(Console.ReadLine());
            double P = Convert.ToDouble(Console.ReadLine());

            double result = (double)N * S / 500 * P;
            Console.WriteLine(result.ToString("N",nfi));
        }
    }
}
