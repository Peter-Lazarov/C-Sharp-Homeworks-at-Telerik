using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    [VersionAttribute(1,1)]
    public class Matrix<T> where T : IComparable
    {
        public T[,] table;
        public Matrix(int rows, int cols)
        {
            table = new T[rows,cols];
        }

        public T ElementGet(int rows, int cols)
        {
            return table[rows, cols];
        }

        public void ElementSet(int rows, int cols, T element)
        {
            this.table[rows, cols] = element;
        }

        public static Matrix<T> operator *(Matrix<T> one, Matrix<T> two)
        {
            var result = new Matrix<T>(one.table.GetLength(0), two.table.GetLength(1));
            for (int i = 0; i < one.table.GetLength(0); i++)
            {
                for (int j = 0; j < one.table.GetLength(1); j++)
                {
                    result.table[i, j] = one.table[i, j] * (dynamic)two.table[i, j];
                }
            }
            return result;
        }
    }
}
