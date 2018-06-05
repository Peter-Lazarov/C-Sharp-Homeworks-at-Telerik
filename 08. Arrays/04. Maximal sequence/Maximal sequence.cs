using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int sequence = 1;
            int max = 0;
            int i = 0;
            int read = 0;
            while (i < n)
            {
                read = Convert.ToInt32(Console.ReadLine());
                if (num == read)
                {
                    sequence++;
                    max = sequence;
                }
                else
                {
                    sequence = 1;
                }
                i++;
                num = read;
            }
            Console.WriteLine(max);
        }
    }
}
