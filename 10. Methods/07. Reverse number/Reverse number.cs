using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {
        static void Reverse(string digits)
        {
            int n = digits.Length;
            char[] all = new char[n];
            all = digits.ToCharArray();
            char[] rev = new char[n];

            for (int i = 0; i < n/2+1; i++)
            {
                rev[n - i - 1] = all[i];
                rev[i] = all[n - i - 1];
            }
            foreach (var item in rev)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Reverse(Console.ReadLine());
        }
    }
}
