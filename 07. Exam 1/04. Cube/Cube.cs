using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Cube
{
    class Cube
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if ((3<n)&&(n<101))
            {
                int AllRows = (n * 2) - 1;
                char space = ' ';
                char colon = ':';
                char top = '/';
                char side = 'X';
                int n1 = n;
                int row = 0;
                int x = 0;
                int xside = -1;

                while (row < AllRows)
                {
                    row++;
                    n1 = n1 - 1;
                    //space
                    for (int s = 0; s < n1; s++)
                    {
                        Console.Write(space);
                    }
                    //colon
                    if ((row == 1) || (row == n) || (row == AllRows))
                    {
                        for (int c = 0; c < n; c++)
                        {
                            Console.Write(colon);
                        }
                    }
                    //top
                    else if (row < n)
                    {
                        Console.Write(colon);
                        for (int i = 0; i < n-2; i++)
                        {
                            Console.Write(top);
                        }
                        Console.Write(colon);
                    }
                    if ((row > n) && (row < AllRows))
                    {
                        Console.Write(colon);
                        for (int s = 0; s < n-2; s++)
                        {
                            Console.Write(space);
                        }
                        Console.Write(colon);
                    }
                    //side
                    if ((1 < row) && (row < n + 1))
                    {
                        xside++;
                        for (x = 0; x < xside; x++)
                        {
                            Console.Write(side);
                        }
                        Console.Write(colon);
                    }
                    else if ((row > n)&&(row < AllRows))
                    {
                        xside--;
                        for (x = 0; x < xside; x++)
                        {
                            Console.Write(side);
                        }
                        Console.Write(colon);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
