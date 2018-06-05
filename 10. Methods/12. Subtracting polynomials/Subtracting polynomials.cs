using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Subtracting_polynomials
{
    class Program
    {
        static string ArrMultiply(int n, string groupone, string grouptwo)
        {
            string result = "";
            int[] One = groupone.Split(' ').Select(int.Parse).ToArray();
            int[] Two = grouptwo.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                One[i] *= Two[i];
            }
            result = string.Join(" ", One);

            return result;
        }
        static string ArrSubstract(int n, string groupone, string grouptwo)
        {
            string result = "";
            int[] One = groupone.Split(' ').Select(int.Parse).ToArray();
            int[] Two = grouptwo.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                One[i] /= Two[i];
            }
            result = string.Join(" ", One);

            return result;
        }
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string groupone = Console.ReadLine();
            string grouptwo = Console.ReadLine();
            Console.WriteLine(ArrMultiply(n, groupone, grouptwo));
            Console.WriteLine(ArrSubstract(n, groupone, grouptwo));
        }
    }
}
