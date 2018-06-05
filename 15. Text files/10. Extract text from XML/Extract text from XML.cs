using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Extract_text_from_XML
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("xml 2.txt");//xml.txt is another test
            List<string> all = new List<string>();
            while (!openFile.EndOfStream)
            {
                all.Add(openFile.ReadLine());
            }
            openFile.Close();

            int begin = 0;
            int end = 0;
            string current = "";

            int i = 0;
            StringBuilder text = new StringBuilder();
            bool closed = true;
            string ready = "";

            //Searching for text
            while (i < all.Count)
            {
                current = all[i];
                while ( end != current.Length)
                {
                    if (closed == true)
                    {
                        begin = current.IndexOf(">", begin);
                    }
                    else
                    {
                        begin = -1;
                    }
                    while ((begin == current.Length - 1)|| (current[begin + 1] == '<'))
                    {
                        begin = current.IndexOf(">", begin + 1);
                        if (begin == current.Length - 1)
                        {
                            break;
                        }
                    }
                    begin++;

                    end = current.IndexOf("</", begin);
                    if (end < 0)
                    {
                        end = current.Length;
                        closed = false;
                    }
                    else
                    {
                        closed = true;
                    }
                    text.Append(current.Substring(begin, end - begin));
                    if (current.Substring(begin, end - begin) != "")
                    {
                        text.Append(" ");
                    }
                }
                i++;
            }
            ready = text.ToString();
            ready = ready.TrimEnd(' ');

            Console.WriteLine(ready);
            stopWatch.Stop();
            Console.WriteLine("Time elapsed in miliseconds {0}",stopWatch.ElapsedMilliseconds);
        }
    }
}
