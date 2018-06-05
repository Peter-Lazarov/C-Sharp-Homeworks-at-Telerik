using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Reverse_sentence
{
    class Program
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            char lastmark = sentence.Last();
            List<int> commas = new List<int>();
            int space = 0;
            List<string> words = new List<string>();
            string reversedsentence = "";
            int s = 0;
            int j = 0;

            sentence = sentence.Remove(sentence.Length - 1);
            for (int i = 0; i <sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    space++;
                }
                else if (sentence[i] == ',')
                {
                    commas.Add(space);
                }
            }
            sentence = sentence.Replace(",", string.Empty);
            words = sentence.Split(' ').ToList();
            words.Reverse();
            
            reversedsentence = string.Join(" ", words);
            
            space = 0;
            while (s >= 0)
            {
                s = reversedsentence.IndexOf(' ', s + 1);
                if (space == commas[j])
                {
                    reversedsentence = reversedsentence.Insert(s, ",");
                    j++;
                    if (j == commas.Count)
                    {
                        break;
                    }
                }
                space++;
            }
            Console.WriteLine(reversedsentence);
        }
    }
}
