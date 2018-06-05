using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSpace
{
    class Start
    {
        static void Main()
        {
            //1. StringBuilder.Substring
            StringBuilder a = new StringBuilder();

            a.Append("word1");
            a.Append(" ");
            a.Append("Must have space");

            Console.WriteLine(a.ToString());
            a = a.Substring(0, 5);
            Console.WriteLine(a.ToString());
            
            ////2. Implement a set of extension methods for IEnumerable<T> that implement 
            ////the following group functions: sum, product, min, max, average.
            //List<int> forSum = new List<int> { 1, 20, 25};
            //Console.WriteLine(forSum.Sumata());

        }
    }
}
