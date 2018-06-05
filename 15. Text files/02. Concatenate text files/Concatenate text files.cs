using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Concatenate_text_files
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader read = new StreamReader("odd file.txt");
            string file1 = read.ReadToEnd();
            read = new StreamReader("m58.txt");
            string file2 = read.ReadToEnd();
            read.Close();
            string location = Environment.CurrentDirectory;
            string resultFile = "result.txt";
            StreamWriter concatenated = new StreamWriter(resultFile);
            concatenated.WriteLine(file1);
            concatenated.WriteLine(file2);
            concatenated.Close();
            Console.WriteLine("Files were concatenated in {0} at {1}", resultFile, location);
        }
    }
}
