using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Maximal_area_sum
{
    class Program
    {
        static void Main()
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\..";
            StreamReader openFile = new StreamReader("matrix.txt");
            int n = Int32.Parse(openFile.ReadLine());
            int[,] all = new int[n,n];
            int[] temp = new int[n];
            string line = "";

            int sum = 0;
            int maxsum = 0;
            int xbegin = 0;
            int xend = xbegin + 2;
            int ybegin = 0;
            int yend = ybegin + 2;
            
            //Gathering data part
            for (int y = 0; y < n; y++)
            {
                line = openFile.ReadLine();
                temp = line.Split(' ').Select(int.Parse).ToArray();
                for (int x = 0; x < n; x++)
                {
                    all[x, y] = temp[x];
                }
            }
            openFile.Close();

            //Calculating part
            while (yend <= n)
            {
                while (xend <= n)
                {
                    for (int y = ybegin; y < yend; y++)
                    {
                        for (int x = xbegin; x < xend; x++)
                        {
                            sum = sum + all[x, y];
                        }
                    }

                    if ((sum > maxsum) && (sum != 0))
                    {
                        maxsum = sum;
                    }
                    sum = 0;
                    xbegin++;
                    xend = xbegin + 2;
                }
                ybegin++;
                xbegin = 0;
                xend = xbegin + 2;
                yend = ybegin + 2;
            }
            Console.WriteLine(maxsum);
        }
    }
}
