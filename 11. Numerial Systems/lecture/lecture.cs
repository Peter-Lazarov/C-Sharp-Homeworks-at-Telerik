using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    class lecture
    {
        static void Main(string[] args)
        {
            //Casting knowledge
            double num = 12.543;

            Console.WriteLine(num);
            Console.WriteLine(num % 1);
            Console.WriteLine((decimal)num % 1);
            Console.WriteLine((int)((decimal)num % 1));
            Console.WriteLine((int)((num % 1) * 1000));
            Console.WriteLine((int)(((decimal)num % 1) * 1000));
        }
    }
}
