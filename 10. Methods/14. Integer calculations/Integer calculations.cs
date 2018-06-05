using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_calculations
{
    class Program
    {
        static int[] Input(string set)
        {
            int[] all = set.Split(' ').Select(int.Parse).ToArray();
            return all;
        }
        static void Calculations(params int[] all)
        {
            int n = 5;
            int sum = 0;
            double avg = 0;
            int product = 0;

            Array.Sort(all);
            
            //Min
            Console.WriteLine(all[0]);
            
            //Max
            Console.WriteLine(all[4]);

            //Sum calc
            for (int i = 0; i < n; i++)
            {
                sum += all[i];
                product *= all[i];
            }

            //Average
            avg = Convert.ToDouble(sum) / n;
            Console.WriteLine(avg.ToString("0.00"));

            //Sum
            Console.WriteLine(sum);

            //Product
            Console.WriteLine(product);
        }
        static void Main()
        {
            string entered = "3 7 9 18 0"; //Console.ReadLine();
            Calculations(Input(entered));
        }
    }
}
