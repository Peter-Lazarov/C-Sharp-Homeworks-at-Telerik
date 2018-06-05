using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Replace_whole_word
{
    class Program
    {
        static void Main()
        {
            ////help from http://my.telerikacademy.com/forum/questions/4453/csharp-%D0%94%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-text-files-7-%D0%B8-8-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0?page=1

            //stopwatch stopwatch = new stopwatch();
            //stopwatch.start();

            //environment.currentdirectory = environment.currentdirectory + @"\..\..";
            //streamreader openfile = new streamreader("original.txt");
            //streamwriter writefile = new streamwriter("file.txt");


            //for (string line; (line = openfile.readline()) != null; )
            //{
            //    line = line.replace("start", "finish");
            //    writefile.writeline(regex.replace(line, @"\bstart\b", "finish"));
            //}
            //openfile.close();
            //writefile.close();
            //stopwatch.stop();
            //console.writeline(stopwatch.elapsedmilliseconds);//about 5s

            //Solution 2
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("original.txt");
            StreamWriter writeFile = new StreamWriter("file.txt");

            for (string line; (line = openFile.ReadLine()) != null; )
            {
                line = line.Replace(" start ", " finish ");
                line = line.Replace(" Start ", " finish ");
                writeFile.WriteLine(line);
            }
            openFile.Close();
            writeFile.Close();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);//About 3.9s
        }
    }
}
