using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int [,]down = new int[n,n];
            int k = 0;
            int m = 1;
            string input = Console.ReadLine();

            if (input == "a")
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        k = m + i + 1;
                        down[i, j] = k;
                    }
                    m = k;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j>0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(down[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (input == "b")
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if ((j % 2)==0)
                        {
                            k = m + i;
                            down[i, j] = k;
                        }
                        else
                        {
                            k = m + n - i;
                            down[i, j] = k;
                        }
                    }
                    if ((j % 2)==0)
                    {
                        m = k;
                    }
                    else
                    {
                        m = k + n;
                    }
                    
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j > 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(down[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (input == "c")
            {
                int a = n - 1;
                k = 1;
                for (int i = n - 1; (i < n) && (a < n) && (k <= n * n); i--, a--)
                {
                    for (int j = 0; (j < n) && (a < n); j++)
                    {
                        if (a<0)
                        {
                            j= Math.Abs(a);
                            a = 0;
                        }
                        down[a, j] = k;
                        k += 1;
                        a += 1;
                    }
                    a = i;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j > 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(down[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (input == "d")
            {
                int direction = 1;
                k = 1;
                int i = 0;
                int j = 0;
                int step = n;
                int stepup = 0;
                while (k < n * n + 1)
                {
                    switch (direction)
                    {
                        case 1:
                            //Down
                            while (i < step)
                            {
                                down[i, j] = k;
                                k++;
                                i++;
                            }
                            direction = 2;
                            i--;
                            j++;
                            break;
                        case 2:
                            //Right
                            while (j < step)
                            {
                                down[i, j] = k;
                                k++;
                                j++;
                            }
                            direction = 3;
                            step -= 1;
                            j--;
                            break;
                        case 3:
                            //Up
                            i--;
                            while (i >= stepup)
                            {
                                down[i, j] = k;
                                k++;
                                i--;
                            }
                            direction = 4;
                            stepup++;
                            i++;
                            break;
                        case 4:
                            //Left
                            j--;
                            while (j >= n - step)
                            {
                                down[i, j] = k;
                                k++;
                                j--;
                            }
                            direction = 1;
                            j++;
                            i++;
                            break;
                        default:
                            Console.WriteLine("Wrong direction");
                            break;
                    }
                }

                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (j > 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(down[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
