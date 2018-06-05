using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Compare_text_files
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader fileRead = new StreamReader("m58.txt");
            int lines = File.ReadAllLines("m58.txt").Count();
            List<string> holdOne = new List<string>(lines);
            int same = 0;
            int different = 0;

            using (fileRead)
            {
                for (int i = 0; i < lines; i++)
                {
                    holdOne.Add(fileRead.ReadLine());
                }
            }
            fileRead = new StreamReader("m57.txt");
            using (fileRead)
            {
                for (int i = 0; i < lines; i++)
                {
                    if (holdOne[i] == fileRead.ReadLine())
                    {
                        same++;
                    }
                    else
                    {
                        different++;
                    }
                }
            }
            Console.WriteLine("Between two files have {0} equal and {1} different lines.", same, different);
        }
    }
}
