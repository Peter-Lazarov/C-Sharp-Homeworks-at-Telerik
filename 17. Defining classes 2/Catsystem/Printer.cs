using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsystem
{
    public static class Printer
    {
        public static void PrintCat(Cat cat)
        {
            Console.WriteLine(cat.Name + " " + cat.Age);
        }
    }
}
