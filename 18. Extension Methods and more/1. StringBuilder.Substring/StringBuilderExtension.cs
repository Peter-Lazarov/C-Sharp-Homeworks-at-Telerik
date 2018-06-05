using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSpace
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            string working = input.ToString();
            working = working.Substring(startIndex, length);
            StringBuilder sub = new StringBuilder();
            sub.Append(working);
            return sub;
        }

        public static T Sumata<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            decimal result = 0;

            for (int i = 0; i < data.Count(); i++)
			{
                result += (dynamic)data.ElementAt(i);
			}
                
            return (T)(dynamic)result;
        }
    }
}
