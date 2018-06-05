using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Longest_string
{
    class Program
    {
        static void Main()
        {
            //17. Longest string
            //Write a program to return the string with maximum length from an array of strings.
            //Use LINQ.
            string[] textAll = new string[] { "ii", "iiii", "i", "iiiiiiiii", "iii" };

            var longestString =
                from str in textAll
                orderby str.Length
                select str;

            Console.WriteLine(longestString.Last());
        }
    }
}
