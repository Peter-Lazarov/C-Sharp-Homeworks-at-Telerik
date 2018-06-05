using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main()
        {
            string pattern = "in";
            string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int index = 0;
            int found = 0;
            int count = -1;

            while (found >= 0)
            {
                found = text.IndexOf(pattern, index, StringComparison.CurrentCultureIgnoreCase);
                index = found + 2;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
