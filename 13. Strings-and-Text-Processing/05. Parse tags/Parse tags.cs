using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string upcase = "<upcase>";
            string upcaseend = "</upcase>";
            
            int index = 0;
            int found = 0;
            int foundend = 0;
            string normalcase = "";
            string uppercase = "";
            StringBuilder finaltext = new StringBuilder();
            string final = "";

            while (found < text.Length - 1)
            {
                uppercase = "";
                found = text.IndexOf(upcase, index);
                if (found < 0)
                {
                    found = text.Length;
                }
                else
                {
                    foundend = text.IndexOf(upcaseend, index);
                    uppercase = text.Substring(found + 8, foundend - (found + 8));
                    uppercase = uppercase.ToUpper();
                }
                normalcase = text.Substring(index, found - index);
                index = foundend + 9;

                finaltext.Append(normalcase);
                finaltext.Append(uppercase);
            }
            final = finaltext.ToString();
            Console.WriteLine(final);
        }
    }
}
