using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sequence_in_matrix
{
    class Program
    {
        static void Main()
        {
            int n = 6;
            int m = 6;

            int[,] all = new int[,] {
                {92, 11, 23, 42, 59, 48},
                {09, 92, 23, 72, 56, 14},
                {17, 63, 92, 46, 85, 95},
                {34, 12, 52, 69, 23, 95},
                {26, 88, 78, 71, 29, 95},
                {26, 34, 16, 63, 39, 95}
            };

            int Seq = 1;
            int Seqmax = 1;

            //Row checking
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (all[i, j] == all[i, (j - 1)])
                    {
                        Seq++;
                    }
                }
                if (Seq > Seqmax)
                {
                    Seqmax = Seq;
                }
                Seq = 1;
            }
            
            //Column checking
            for (int j = 0; j < m; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    if (all[i, j] == all[i - 1, j])
                    {
                        Seq++;
                    }
                }
                if (Seq > Seqmax)
                {
                    Seqmax = Seq;
                }
                Seq = 1;
            }

            //Diagonal checking
            //Right
            for (int i = 1, j = 1; (i < n) || (j < m); i++, j++)
            {
                if (all[i,j] == all[i-1, j-1])
                {
                    Seq++;
                }
            }
            if (Seq > Seqmax)
            {
                Seqmax = Seq;
            }

            //Left
            for (int i = 1, j = m - 2; (i < n) || (j > -1); i++, j--)
            {
                if (all[i, j] == all[i - 1, j + 1])
                {
                    Seq++;
                }
            }
            if (Seq > Seqmax)
            {
                Seqmax = Seq;
            }
            Console.WriteLine(Seqmax);
        }
    }
}
