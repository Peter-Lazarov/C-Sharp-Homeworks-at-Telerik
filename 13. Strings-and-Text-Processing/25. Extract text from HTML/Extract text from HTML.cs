using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Extract_text_from_HTML
{
    class Program
    {
        static void Main()
        {
            //Tova e ako se vavajda ot consolata
            //string s = " ";
            //List<string> all = new List<string> { };
            //while (!string.IsNullOrEmpty(s))
            //{
            //    //your code for each line
            //    s = Console.ReadLine();
            //    all.Add(s);
            //}

            //open
            //close
            //write (open, close, false)

            List<string> all = new List<string> {"<html>",
            "<head><title>News</title></head>",
            "<body><p><a href=\"http://academy.telerik.com\">Telerik",
            "Academy</a>aims to provide free real-world practical", 
            "training for young people who want to turn into",
            "skilful .NET software engineers.</p></body>",
            "</html>"};

            int begin = 0;
            int end = 0;
            string current = "";
            string title = "";

            int i = 0;
            StringBuilder text = new StringBuilder();
            bool closed = true;
            string ready = "";
            for (i = 0; i < all.Count; i++)
            {
                current = all[i];
                int tbegin = current.IndexOf("<title>");
                if (tbegin > -1)
                {
                    title = current.Substring(tbegin + 7, current.IndexOf("</", tbegin) - (tbegin + 7));
                    i++;
                    break;
                }
            }

            //Searching for text
            while (i < all.Count)
            {
                current = all[i];
                while (end != current.Length)
                {
                    if (closed == true)
                    {
                        begin = current.IndexOf(">", begin);
                    }
                    else
                    {
                        begin = -1;
                    } 
                    while (current[begin + 1] == '<')
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
                    text.Append(" ");
                }
                i++;
            }
            ready = text.ToString();
            ready = ready.TrimEnd(' ');

            Console.WriteLine(ready);
        }
    }
}
