using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Order_words
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            List<string> words = text.Split(' ', '.', '!', '?').ToList();

            words = words.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            words.Sort();

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
