using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Binary_short
{
    class Program
    {
         static long[] DectoBin(long dec)
        {
            long[] bin = new long[16];
            int i = 0;

            while (dec > 0)
            {
                bin[i] = dec % 2;
                dec /= 2;
                i++;
            }
            //long[] ready = new long[i];
            //Array.Copy(bin, ready, i);
            Array.Reverse(bin);
            return bin;
        }
         static void Main()
         {
             long number = -10000;
             string binary = "";
             long[] binnum = new long[16];

             if (number > 0)
             {
                 binnum = DectoBin(number);
                 binary = (String.Join("", binnum));
             }
             else if (number == 0)
             {
                 binary = (String.Join("", DectoBin(0)));
             }
             else if (number < 0)
             {
                 number = 32768 + number;
                 binnum = DectoBin(number);
                 binnum[0] = 1;
                 binary = (String.Join("", binnum));
             }
             Console.WriteLine(binary);
         }
    }
}
