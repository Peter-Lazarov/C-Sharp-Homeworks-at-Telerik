using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15.Replace_tags
{
    class Program
    {
        static void Main()
        {
            //input
            //@"<a href="URL">TEXT</a>";

            //<a href="
            //URL
            //">
            //TEXT
            //</a>
            //Target is [TEXT](URL)
            //V uslovieto um sa ostavili http, a az go maham
            string sometext = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            int http = 0;
            int urlbegin = 0;
            int urlend = 0;
            string ahref = "";

            string text = "";
            int textbegin = 0;
            int textend = 0;

            while (urlbegin >= 0)
            {
                urlbegin = sometext.IndexOf("href=\"", urlbegin);

                if (urlbegin < 0)
                {
                    break;
                }
                else if (urlbegin + 6 == sometext.IndexOf("http://", urlbegin))
                {
                    http = 13;
                }
                else
                {
                    http = 6;
                }
                urlbegin += http;

                urlend = sometext.IndexOf("\"", urlbegin);
                ahref = "(" + sometext.Substring(urlbegin, urlend - urlbegin) + ")";
                textbegin = sometext.IndexOf(">", urlend) + 1;
                textend = sometext.IndexOf("</a>", textbegin);
                text = " [" + sometext.Substring(textbegin, textend - textbegin) + "]";

                urlbegin -= http + 4;
                sometext = sometext.Remove(urlbegin, textend + 4 - urlbegin);
                sometext = sometext.Insert(urlbegin, text + ahref);
                urlbegin = textend;
            }
            Console.WriteLine(sometext);
        }
    }
}
