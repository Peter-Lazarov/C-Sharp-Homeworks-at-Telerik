using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Spiral_Matrix
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (1 < n & n < 21)
            {
                int[,] matrix = new int[n, n];
                int count = n * n;
                int direction = 3;
                int positionX = -1;
                int positionY = 0;
                int stepCount = n;
                int stepPosition = 0;
                int stepChange = 1;
                for (int i = 1; i < (count + 1); i++)
                {
                    if (stepPosition < stepCount)
                    {
                        stepPosition++;
                    }
                    else
                    {
                        stepPosition = 1;
                        if (stepChange == 1)
                        {
                            stepCount--;
                        }
                        stepChange = (stepChange + 1) % 2;
                        direction = (direction + 1) % 4;
                    }

                    switch (direction)
                    {
                        case 0:
                            positionY++;
                            break;
                        case 1:
                            positionX--;
                            break;
                        case 2:
                            positionY--;
                            break;
                        case 3:
                            positionX++;
                            break;
                    }
                    matrix[positionY, positionX] = i;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Input is out of range");
            }
        }
    }
}