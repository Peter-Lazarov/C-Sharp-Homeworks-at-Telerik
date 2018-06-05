using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
        static void Main()
        {
            string url = "https://github.com/gentoo/gentoo.git";//"http://telerikacademy.com/Courses/Courses/Details/212";
            int devider = url.IndexOf(':',0);
            int slasher = url.IndexOf('/',devider + 3);
            string protocol = url.Substring(0, devider);
            devider += 3;
            string server = url.Substring(devider, slasher - devider);
            string resource = url.Substring(slasher, url.Length - slasher);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
