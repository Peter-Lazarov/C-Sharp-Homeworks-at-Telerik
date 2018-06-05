using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Merge_sort
{
    class Program
    {
        //https://www.youtube.com/watch?v=TzeBrDU-JaY&feature=youtu.be

        // Moje da se razgleda i 
        //http://pastebin.com/zaUHyKRg

        public static int p = Convert.ToInt32(Console.ReadLine());
        static void Main()
        {
            int[] inputA = new int[p];
            for (int g = 0; g < p; g++)
            {
                inputA[g] = Convert.ToInt32(Console.ReadLine());
            }

            MergeSort(inputA);
        }
        static void Merge(int[] l, int[] r, int[] a)
        {
            int nl = l.Length;
            int nr = r.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while ((i < nl) && (j < nr))
            {
                if (l[i] <= r[j])
                {
                    a[k] = l[i];
                    i++;
                }
                else
                {
                    a[k] = r[j];
                    j++;
                }
                k++;
            }
            while (i < nl)
            {
                a[k] = l[i];
                i++;
                k++;
            }
            while (j < nr)
            {
                a[k] = r[j];
                j++;
                k++;
            }
        }
        static void MergeSort(int[] a)
        {
            int n = a.Length;
            if (n<2)
            {
                return;
            }
            int mid = n / 2;
            int[] l = new int[mid];
            int[] r = new int[n-mid];

            for (int i = 0; i < mid; i++)
            {
                l[i] = a[i];
            }

            for (int i = mid; i < n; i++)
            {
                r[i-mid] = a[i];
            }
            MergeSort(l);
            MergeSort(r);
            Merge(l, r, a);

            if (n == p)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
