using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multy_arrays
{
    class Lecture
    {
        static void Main()
        {
            //// Feb.2017
            //int[] oned = new int[5] { 1, 2, 3, 4, 5 };
            //int[,] twod = new int[2, 2] {
            //    {1, 2},
            //    {3, 4}
            //};
            //Console.WriteLine(twod[0,1]);
            //int[, ,] three = new int[2, 2, 2]{
            //    {
            //        {1,2},
            //        {1,2},
            //    },
            //    {
            //        {1,2},
            //        {1,2}
            //    }
            //};

            ////May.2017
            //Jagged arrays
            //int[][] arrdouble = new int[3][];
            //for (int i = 0; i < 3; i++)
            //{
            //    arrdouble[i] = new int[5 + i];
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < arrdouble[i].GetLength(0); j++)
            //    {
            //        Console.Write(arrdouble[i][j]);
            //    };
            //    Console.WriteLine();
            //};

            //for (int i = 0; i < 3; i++)
            //{
            //    foreach (int cell in arrdouble[i])
            //    {
            //        Console.Write(cell);
            //    };
            //    Console.WriteLine();
            //};

            //// First try
            //int[][] jarray = new int[3][];

            //for (int i = 0; i < 3;i++)
            //{
            //    string[] userin = Console.ReadLine().Split(' ');
            //    jarray[i] = new int[userin.Length];
            //    for (int j = 0; j < userin.Length; j++)
            //    {
            //        jarray[i][j] = int.Parse(userin[j]);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < jarray[i].GetLength(0); j++)
            //    {
            //        Console.Write(jarray[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //// Secound try
            //int[][] j2array = new int[2][];

            //for (int i = 0; i < 2;i++ )
            //{
            //    string[] enter = Console.ReadLine().Split(' ');
            //    j2array[i] = new int[enter.Length];
            //    for (int j = 0; j < enter.Length;j++)
            //    {
            //        j2array[i][j] = Convert.ToInt32(enter[j]);
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < j2array[i].GetLength(0); j++)
            //    {
            //        Console.Write(j2array[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            ////Try three
            //int row = 2;
            //int[][] jag3 = new int[row][];

            //for (int i = 0; i < row; i++)
            //{
            //    string[] text = Console.ReadLine().Split(' ');
            //    jag3[i] = new int[text.Length];
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        jag3[i][j] = Convert.ToInt32(text[j]);
            //    }
            //}

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < jag3[i].GetLength(0); j++)
            //    {
            //        Console.Write(jag3[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //////Pascal Triangle

            //int row = 10;
            //int[][] triangle = new int[row + 1][];

            //triangle[0] = new int[] { 1 };

            //for (int i = 1; i < row; i++)
            //{
            //    triangle[i] = new int[i + 1];
            //    triangle[i][0] = 1;
            //    for (int j = 1; j < i; j++)
            //    {
            //        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            //    }
            //    triangle[i][i] = 1;
            //}
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < i+1; j++)
            //    {
            //        Console.Write(triangle[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //// Multiply Matrixes
            //int cell = 0;
            //int[,] matrixA = new int[,]
            //{
            //    {1,2,3},
            //    {4,5,6},
            //    {7,8,9}
            //};
            //int[,] matrixB = new int[,] 
            //{
            //    {0,1,0},
            //    {7,3,4},
            //    {2,6,3}
            //};
            //int[,] matrixC = new int[3, 3];
            //// matrixC[0, 0] = matrixA[0, 0] * matrixB[0, 0] + matrixA[0, 1] * matrixB[1, 0] + matrixA[0, 2] * matrixB[2, 0];
            //// matrixC[0, 1] = matrixA[0, 0] * matrixB[0, 1] + matrixA[0, 1] * matrixB[1, 1] + matrixA[0, 2] * matrixB[2, 1];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        cell = 0;
            //        for (int a = 0; a < 3; a++)
            //        {
            //            cell = cell + (matrixA[i, a] * matrixB[a, j]);
            //        }
            //        matrixC[i, j] = cell;
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matrixC[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //// Rank practice (kolko izmeren e)
            //var arr = new int[100, 10, 20, 30];
            //Console.WriteLine(arr.Rank);

            ////Stage 2
            //var arr = new int[]{1, 6, 4, 8, 9, 2, 3};
            //Console.WriteLine(Array.IndexOf(arr,8));

            ////Stage 3
            //Copy array
            //var arr = new int[] { 1, 6, 4, 8, 9, 2, 3 };
            //int[] arr2 = new int[16];
            //Array.Copy(arr,arr2,5);

            //Console.WriteLine(string.Join(" ", arr2));

            ////Stage 4
            ////Copy array with index
            //var arr = new int[] { 1, 6, 4, 8, 9, 2, 3 };
            //int[] arr2 = new int[16];
            //Array.Copy(arr, 2, arr2, 6, 5);

            //Console.WriteLine(string.Join(" ", arr2));

            //int n = 4;// Convert.ToInt32(Console.ReadLine());
            //int m = 4;// Convert.ToInt32(Console.ReadLine());
            //string input = "";
            //int[] line = new int[m];
            //int[,] down = new int[n, m];
            //for (int i = 0; i < n; i++)
            //{
            //    input = Console.ReadLine();
            //    line = input.Split(' ').Select(int.Parse).ToArray();
            //    for (int j = 0; j < m; j++)
            //    {
            //        down[i, j] = line[j];
            //    }
            //}
        }
    }
}
