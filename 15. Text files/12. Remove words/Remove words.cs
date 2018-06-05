using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Remove_words
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader wordsFile = new StreamReader("words.txt");
            List<string> words = new List<string>();
            List<string> edited = new List<string>();
            string currentLine = "";
            while (!wordsFile.EndOfStream)
            {
                words.Add(wordsFile.ReadLine());
            }
            wordsFile.Close();

            StreamReader textFile = new StreamReader("text.txt");
            while (!textFile.EndOfStream)
            {
                currentLine = textFile.ReadLine();
                for (int i = 0;(i < words.Count()) && (currentLine != null); i++)
                {
                    while ((currentLine.IndexOf(words[i]) > -1) || (currentLine.IndexOf("  ") > -1))
                    {
                        currentLine = currentLine.Replace(words[i], "");
                        currentLine = currentLine.Replace("  ", " ");
                    }
                }
                if (currentLine[0] == ' ')
                {
                    currentLine = currentLine.Remove(0, 1);
                }
                edited.Add(currentLine);
            }
            wordsFile.Close();
            textFile.Close();
            StreamWriter writeFile = new StreamWriter("text.txt");
            for (int i = 0; i < edited.Count; i++)
            {
                writeFile.WriteLine(edited[i]);
            }
            writeFile.Close();
        }
    }
}
