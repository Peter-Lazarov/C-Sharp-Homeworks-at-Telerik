using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.Save_sorted_names
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("input.txt");
            int lines = File.ReadAllLines("input.txt").Count();
            string[] all = new string[lines];
            using (openFile)
            {
                for (int i = 0; i < lines; i++)
                {
                    all[i] = openFile.ReadLine();
                }
            }
            Array.Sort(all);
            StreamWriter writeFile = new StreamWriter("output.txt");
            using (writeFile)
            {
                for (int i = 0; i < lines; i++)
                {
                    writeFile.WriteLine(all[i]);
                }
            }
        }
    }
}