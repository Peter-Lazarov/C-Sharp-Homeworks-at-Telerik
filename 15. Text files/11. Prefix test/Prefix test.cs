using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11.Prefix_test
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("test text.txt");
            StreamWriter writeFile = new StreamWriter("deleted file.txt");
            string currentLine = "";
            int begin = 0;
            int end = 0;
            for (int i = 0; !openFile.EndOfStream; i++)
            {
                currentLine = openFile.ReadLine();
                while (currentLine.IndexOf("test") > -1)
                {
                    begin = currentLine.IndexOf("test", begin);
                    end = currentLine.IndexOf(" ", begin) + 1;
                    currentLine = currentLine.Remove(begin, end - begin);
                }
                writeFile.WriteLine(currentLine);
            }
            openFile.Close();
            writeFile.Close();
        }
    }
}
