using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Text_ot_Number
{
    class Program
    {
        static void Main()
        {
            //int M = 9999;
            //string letter = "My nickname, when I was 25, was Pencho8473848399 ;-)@";
            //result must be 2943

            int M = Convert.ToInt32(Console.ReadLine());
            string letter = Console.ReadLine();
            int i = 0;
            int strLenght = letter.Length;
            int currentCharacter = 0;
            long result = 0;

            while (i < strLenght)
            {
                currentCharacter = letter[i];
                //Checking for numbers
                if ((47 < currentCharacter) & (currentCharacter < 58))
                {
                    result = result * (currentCharacter - 48);
                }
                //Checking for letters
                else if ((64 < currentCharacter) & (currentCharacter < 123))
                {
                    if ((64 < currentCharacter) & (currentCharacter < 91))
                    {
                        result = result + (currentCharacter - 65);
                    }
                    else
                    {
                        result = result + (currentCharacter - 97);
                    }
                }
                //Checking for @ to stop
                else if (currentCharacter == 64)
                {
                    i = strLenght;
                }
                else
                {
                    result = result % M;
                }
                i++;
            }
            Console.WriteLine(result);
        }
    }
}