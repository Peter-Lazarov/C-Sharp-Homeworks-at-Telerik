using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Count_words
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader wordsFile = new StreamReader("words.txt");
            List<string> words = new List<string>();
            string currentLine = "";

            while (!wordsFile.EndOfStream)
            {
                words.Add(wordsFile.ReadLine());
            }
            wordsFile.Close();

            int[] wordsCount = new int[words.Count];
            int begin = 0;
            StreamReader textFile = new StreamReader("text.txt");
            
            while (!textFile.EndOfStream)
            {
                currentLine = textFile.ReadLine();
                for (int i = 0; (i < words.Count()) && (currentLine != null); i++)
                {
                    while (currentLine.IndexOf(words[i], begin) > -1)
                    {
                        wordsCount[i]++;
                        begin = currentLine.IndexOf(words[i], begin) + 1;
                    }
                    begin = 0;
                }
            }
            wordsFile.Close();
            textFile.Close();
            StreamWriter writeFile = new StreamWriter("words count.txt");
            for (int i = 0; i < words.Count; i++)
            {
                words[i] += " " + wordsCount[i];
                writeFile.WriteLine(words[i]);
            }
            writeFile.Close();
        }
    }
}
