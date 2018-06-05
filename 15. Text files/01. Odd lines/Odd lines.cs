using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_lines
{
    class Program
    {
        static void ReadOdd()
        {
            StreamReader read = new StreamReader(@"..\..\odd file.txt");
            string line = read.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                read.ReadLine();
                line = read.ReadLine();
            }
        }
        static void Main()
        {
            ReadOdd();
        }
    }
}
