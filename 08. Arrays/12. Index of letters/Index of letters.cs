using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Index_of_letters
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int n = word.Length;
            char[] letters = word.ToArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();
            int a = 0;
            int i = 0;

            while (i<n)
            {
                a = Array.IndexOf(alphabet, letters[i]);
                Console.WriteLine(a);
                i++;
            }
        }
    }
}
