using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Forbidden_words
{
    class Program
    {
        static void Main()
        {
            string censored = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
                //"PHP is a good language CLR, but PHP is very CLR spageyi code. PHP make some CLR auto things also.";
            string word = "PHP CLR Microsoft";

            string[] words = word.Split(' ').ToArray();
            string asterix = "";

            for (int i = 0; i < words.Count(); i++)
            {
                asterix = new String('*', words[i].Length);
                censored = censored.Replace(words[i], asterix);
            }

            Console.WriteLine(censored);
        }
    }
}
