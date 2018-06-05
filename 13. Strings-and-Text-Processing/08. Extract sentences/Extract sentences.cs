using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class Program
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."; //"Vratza is small city. Mezdra big village.";
            string word = " in ";
            int begin = 0;
            int end = 0;
            List<int> punctuation = new List<int>() { 0 };
            int found = 0;

            int point = 0;
            int exclamation = 0;
            int question = 0;

            string result = "";

            while (point + exclamation + question > -3)
            {
                point = text.IndexOf('.', punctuation.Last() + 1);
                exclamation = text.IndexOf('!', punctuation.Last() + 1);
                question = text.IndexOf('?', punctuation.Last() + 1);
                if (point >= 0)
                {
                    punctuation.Add(point);
                }
                else if (exclamation >= 0)
                {
                    punctuation.Add(exclamation);
                }
                else if (question >= 0)
                {
                    punctuation.Add(question);
                }
            }
            punctuation[0] = -2;
            found = text.IndexOf(word, end);
            do
            {
                begin = punctuation.Last(a => a < found) + 2;
                end = punctuation.First(b => b > found);
                result += text.Substring(begin, end + 1 - begin);
                found = text.IndexOf(word, end);
            } while (found >= 0);
            Console.WriteLine(result);
        }
    }
}
