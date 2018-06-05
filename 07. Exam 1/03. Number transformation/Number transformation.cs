using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Number_transformation
{
    class Program
    {
        static void Main()
        {
            string number = "99999999999999999";

            int numberLenght = 1;
            int sum = 0;
            BigInteger sumproduct = 1;
            int transformation = 0;
            int result = 0;

            while(result != 1)
            {
                while (numberLenght > 0)
                {
                    numberLenght = number.Length - 1;
                    number = number.Substring(0, numberLenght);
                    for (int i = 0; i < number.Length; i += 2 )
                    {
                        sum += (number[i] - '0');
                    }
                    sumproduct *= sum != 0 ? sum : 1;
                    sum = 0;
                }
                transformation++;
                number = Convert.ToString(sumproduct);
                numberLenght = number.Length;
                if ((numberLenght == 1) && transformation < 10)
                {
                    result = 1;
                    Console.WriteLine(transformation);
                    Console.WriteLine(sumproduct);
                }
                else if (transformation >= 10)
                {
                    result = 1;
                    Console.WriteLine(sumproduct);
                }
                sumproduct = 1;
            }            
        }
    }
}
