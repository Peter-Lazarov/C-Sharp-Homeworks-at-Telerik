using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    class lecture
    {
        static void Main()
        {
            //Try 1
            DateTime proba = DateTime.Now;
            Console.WriteLine(proba.AddHours(1));
            Console.WriteLine(proba.AddHours(2));
            proba = proba.AddHours(3);
            Console.WriteLine(proba);

        }
    }
}
