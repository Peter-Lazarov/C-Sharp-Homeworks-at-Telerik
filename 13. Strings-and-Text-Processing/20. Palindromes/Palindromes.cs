using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = "I like ABBA, lamal, exe files.";
            int begin = 0;
            int end = 0;

            int mid = 0;
            int wlength = 0;
            string currentword = "";
            int letter = 0;
            List<string> words = new List<string>();
            List<string> palindromes = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] < 'A' || text[i] > 'z')
                {
                    end = i;
                    words.Add(text.Substring(begin, end - begin));
                    begin = end + 1;
                }
            }
            words = words.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            for (int i = 0; i < words.Count; i++)
            {   
                wlength = words[i].Length - 1;
                if (wlength == 0)
                {
                    i++;
                    wlength = words[i].Length - 1;
                }
                currentword = words[i];
                letter = 0;
                mid = wlength / 2;
                for (int j = 0; j < mid + 1; j++)
                {
                    if (currentword[0 + j] == currentword[wlength - j])
                    {
                        letter++;
                    }
                    else
                    {
                        j = mid;
                    }
                }
                if (mid + 1 == letter)
                {
                    palindromes.Add(currentword);
                }
            }

            Console.WriteLine(string.Join(" ", palindromes));
        }
    }
}