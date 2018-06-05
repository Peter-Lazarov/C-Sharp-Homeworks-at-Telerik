using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Delete_odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //First solution
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("original.txt");
            long lines = 0;

            for (lines = 0; !openFile.EndOfStream; lines++)
            {
                openFile.ReadLine();
            }
            string[] all = new string[lines];
            openFile.Close();

            openFile = new StreamReader("original.txt");
            for (int i = 0; i < lines; i++)
            {
                openFile.ReadLine();
                all[i] = openFile.ReadLine();
            }
            openFile.Close();

            StreamWriter writeFile = new StreamWriter("file.txt");//"original.txt");
            for (int i = 0; i < lines/2; i++)
            {
                writeFile.WriteLine(all[i]);
            }
            writeFile.Close();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds); //About 4,3s
        }
    }
}
