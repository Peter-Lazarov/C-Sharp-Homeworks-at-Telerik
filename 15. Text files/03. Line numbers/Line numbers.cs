using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Line_numbers
{
    class Program
    {
        static void Main()
        {
            //Reading by lines
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader reader = new StreamReader("m58.txt");
            StringBuilder between = new StringBuilder();
            string readystring = "";
            using (reader)
            {
                string currentLine = reader.ReadLine();
                int count = 1;
                while (currentLine != null)
                {
                    between.Append(count);
                    between.Append(". ");
                    between.Append(currentLine);
                    between.Append("\r\n");
                    count++;
                    currentLine = reader.ReadLine();
                }
            }
            readystring = between.ToString();
            StreamWriter writer = new StreamWriter("ready.txt");
            using(writer)
            {
                writer.WriteLine(readystring);
            }
        }
    }
}
