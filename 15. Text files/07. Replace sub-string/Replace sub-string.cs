using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace _07.Replace_sub_string
{
    class Program
    {
        static void Main()
        {
            //First solution
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            //Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            //StreamReader openFile = new StreamReader("original.txt");
            //long lines = 0;

            //for (lines = 0; !openFile.EndOfStream; lines++)
            //{
            //    openFile.ReadLine();
            //}
            //string[] all = new string[lines];
            //openFile.Close();

            //openFile = new StreamReader("original.txt");
            //for (int i = 0; i < lines; i++)
            //{
            //    all[i] = openFile.ReadLine();
            //    all[i] = all[i].Replace("start", "finish");
            //}
            //openFile.Close();

            //StreamWriter writeFile = new StreamWriter("file.txt");//"original.txt");
            //for (int i = 0; i < lines; i++)
            //{
            //    writeFile.WriteLine(all[i]);
            //}
            //writeFile.Close();
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.ElapsedMilliseconds); //About 7,4s


            //Secound solution
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("original.txt");
            StreamWriter writeFile = new StreamWriter("file.txt");


            for (string line; (line = openFile.ReadLine()) != null;)
            {
                line = line.Replace("start", "finish");
                writeFile.WriteLine(line);
            }
            openFile.Close();
            writeFile.Close();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds); //About 4s
        }
    }
}
