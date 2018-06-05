using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Extract_e_mails
{
    class Program
    {
        public static List<string> email = new List<string>();
        public static List<string> host = new List<string>();
        public static List<string> domain = new List<string>();
        static void MailSearch(string text)
        {
            int at = 0;
            at = text.IndexOf('@', at);
            
            int space = 0;
            int point = 0;
            int comma = 0;
            int dot = 0;

            for (int i = 0; at >= 0; i++)
            {
                for (space = at; text[space] != ' '; space--)
                {
                }
                email.Add(text.Substring(space, at - space));
                point = text.IndexOf('.', at);
                host.Add(text.Substring(at + 1, point - at - 1));

                space = text.IndexOf(' ', point);
                comma = text.IndexOf(", ", point);
                dot = text.IndexOf(". ", point);

                if ((space > comma) && (comma > 0))
                {
                    space = comma;
                }
                else if ((space > dot) && (dot > 0))
                {
                    space = dot;
                }
                else if (space == -1)
                {
                    space = text.Length;
                }

                domain.Add(text.Substring(point + 1, space - point - 1));
                at = text.IndexOf('@', space);
            }
        }
        static void Main()
        {
            string input = "I write some text that contain email peter.lazarov86@gmail.com, pl_trade86@hotmail.com and some more eco.tech86@hotmail.com";
            MailSearch(input);
        }
    }
}
