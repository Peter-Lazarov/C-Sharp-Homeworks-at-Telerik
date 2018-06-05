using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Binary_search
{
    class Program
    {
        static void Main()
        {
            int n = 10;
            int[] nums = { 1, 2, 4, 8, 16, 31, 32, 64, 77, 99 };
            //int[] nums = new int[n];
            int x = 32;
            Array.Sort(nums);
            int l = 0;
            int r = n - 1;
            int mid = 0;
            int result = 0;
            int current = 0;

            while (current != x)
            {
                if (x < current)
                {
                    r = mid - 1;
                }
                else if (current < x)
                {
                    l = mid + 1;
                }
                mid = (l + r) / 2;

                current = nums[mid];
                result = mid;

                if (l>r)
                {
                    current = -1;
                    x = -1;
                    result = -1;
                }
            }
            Console.WriteLine(result);
        }
    }
}
