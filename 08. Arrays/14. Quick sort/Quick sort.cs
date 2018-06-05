using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Quick_sort
{
    class Program
    {
        //https://www.youtube.com/watch?v=COk73cpQbFQ

        public static int p = Convert.ToInt32(Console.ReadLine());
        static int Partition(int[] A, int start, int end)
        {
            int pivot = A[end];
            int pIndex = start;
            int temp = 0;
            for (int i = start; i < end; i++)
            {
                if (A[i] <= pivot)
                {
                    temp = A[i];
                    A[i] = A[pIndex];
                    A[pIndex] = temp;
                    pIndex++;
                }
            }
            temp = A[pIndex];
            A[pIndex] = A[end];
            A[end] = temp;
            return pIndex;
        }
        static int[] QuickSort(int[] A, int start, int end)
        {
            if (start < end)
            {
                int pIndex = Partition(A, start, end);
                QuickSort(A, start, pIndex - 1);
                QuickSort(A, pIndex + 1, end);
            }
            return A;
        }
        static void Main()
        {
            int[] inputA = new int[p];
            for (int g = 0; g < p; g++)
            {
                inputA[g] = Convert.ToInt32(Console.ReadLine());
            }
            int[] A = QuickSort(inputA, 0, p - 1);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}
