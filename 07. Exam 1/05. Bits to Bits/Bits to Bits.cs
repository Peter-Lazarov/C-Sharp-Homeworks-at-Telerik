using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bits_to_Bits
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int num = 2;
            int bit = 0;
            
            int maxZero = 0;
            int currentZero = 0;

            int maxOnes = 0;
            int currentOnes = 0;

            int lastBit = 5555;

            for (int i = 0; i < n; i++)
            {   
                num = Convert.ToInt32(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    bit = ((1 << j) & num) >> j;

                    if (bit == 1)
                    {
                        if (lastBit == 1)
                        {
                            currentOnes++;
                        }
                        else
                        {
                            maxZero = Math.Max(maxZero, currentZero);
                            currentOnes = 1;
                            currentZero = 0;
                        }
                    }
                    else
                    {
                        if (lastBit == 0)
                        {
                            currentZero++;
                        }
                        else
                        {
                            maxOnes = Math.Max(maxOnes, currentOnes);
                            currentOnes = 0;
                            currentZero = 1;
                        }
                    }
                    lastBit = bit;
                }
            }
            maxZero = Math.Max(maxZero, currentZero);
            maxOnes = Math.Max(maxOnes, currentOnes);
            Console.WriteLine(maxZero);
            Console.WriteLine(maxOnes);
        }
    }
}