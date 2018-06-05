using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Word_dictionary
{
    class Program
    {
        //https://social.msdn.microsoft.com/Forums/vstudio/en-US/66bcce8d-0d29-4c55-9e35-634d37e25505/how-can-i-find-indices-of-an-element-in-2d-array?forum=csharpgeneral
        //How Can I Find indices of an element in 2D array??
        public static int x = 0;
        public static int y = 0;
        //public static Tuple<int, int> Coordinate(string[,] dictonary, string searched)
        //{
        //    int w = dictonary.GetLength(0);
        //    int h = dictonary.GetLength(1);
        //    for (int x = 0; x < w; ++x)
        //    {
        //        for (int y = 0; y < h; ++y)
        //        {
        //            if (dictonary[x,y].Equals(searched))
        //            {
        //                return Tuple.Create(x, y);
        //            }
        //        }
        //    }

        //    return Tuple.Create(-1, -1);
        //}
        public static void Coordinate(string[,] dictonary, string searched)
        {
            int w = dictonary.GetLength(0);
            int h = dictonary.GetLength(1);
            for (x = 0; x < w; ++x)
            {
                for (y = 0; y < h; ++y)
                {
                    if (dictonary[x, y].Equals(searched))
                    {
                        return;
                    }
                }
            }
            x = -1;
            y = -1;
        }
        static void Main()
        {
            //.NET platform for applications from Microsoft
            //CLR managed execution environment for .NET
            //namespace hierarchical organization of classes
            string searched = "CLR";
            string[,] dictonary = new string[,] {
                {
                    ".NET","CLR","namespace"
                },
                {
                    "platform for applications from Microsoft",
                    "managed execution environment for .NET",
                    "hierarchical organization of classes"
                }
            };
            Coordinate(dictonary, searched);
            
            Console.WriteLine(searched);
            Console.WriteLine(dictonary[x + 1, y]);

        }
    }
}
