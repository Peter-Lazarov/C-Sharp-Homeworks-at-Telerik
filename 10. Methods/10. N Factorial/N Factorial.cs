using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.N_Factorial
{
    class Program
    {
        static string Multiply(string num1, string num2)
        {
            int n1 = 0;
            int n2 = 0;
            int nr = num1.Length + num2.Length;
            int nrposition = 1;
            int[] result = new int [nr];
            if (num1.Length == 1 && num2.Length > 1)
            {
                string change = num2;
                num2 = num1;
                num1 = change;
            }

            nr = num1.Length + num2.Length - nrposition;
            nrposition++;
            for (int j = num2.Length - 1; j >= 0; j--, nrposition++)
            {
                n2 = num2[j] - '0';
                for (int i = num1.Length - 1; i >= 0; i--, nr--)
                {
                    n1 = num1[i] - '0';
                    result[nr] += n1 * n2 % 10;
                    result[nr - 1] += n1 * n2 / 10;
                    if (result[nr] >= 10)
                    {
                        result[nr - 1] += result[nr] / 10;
                        result[nr] %= 10;
                    }
                }
                nr = num1.Length + num2.Length - nrposition;
            }
            string sresult = String.Join("", result);
            if (result[0] == 0)
            {
                sresult = sresult.Remove(0, 1);
            }
            return sresult;
        }
        static void Main()
        {
            int n = 10;
            string re = "1";
            for (int i = 2; i < n + 1; i++)
            {
                re = Multiply(re, Convert.ToString(i));
            }
            Console.WriteLine(re);
        }

        //// Not working program from internet
        ////http://www.geeksforgeeks.org/multiply-large-numbers-represented-as-strings/
        ////Muliplies str1 and str 2 and prints result
        //static string multiply(string num1, string num2)
        //{
        //    int n1 = num1.Length;
        //    int n2 = num2.Length;

        //    if (n1 == 0 || n2 == 0)
        //    {
        //        return "0";
        //    }

        //    //the result number in list in reverse order
        //    List<int> result = new List<int>(n1 + n2);
        //    for (int a = 0; a < n1 + n2; a++)
        //    {
        //        result.Add(0);
        //    }

        //    //indexes for finding positions in result
        //    int i_n1 = 0;
        //    int i_n2 = 0;

        //    //Go from right to left in num1
        //    int carry = 0;
        //    int sum = 0;
        //    int i = 0;

        //    for (i = n1-1; i >= 0; i--)
        //    {
        //        carry = 0;
        //        n1 = num1[i] - '0';

        //        //Shift position to left after every multiplication of a digit in num2
        //        i_n2 = 0;

        //        //Go from right to left in num2
        //        for (int j = n2 - 1; j >= 0; j--)
        //        {
        //            //Take current digit of secound number
        //            n2 = num2[j] - '0';
        //            //Multiply with current digit of first number and add result to previously
        //            //stored result at current position.
        //            sum = n1 * n2 + result[i_n1 + i_n2] + carry;

        //            //Carry for next iteration
        //            carry = sum / 10;

        //            //Store result
        //            result[i_n1 + i_n2] = sum % 10;
        //            i_n2++;
        //        }
        //        //Store carry in next cell
        //        if (carry > 0)
        //        {
        //            result[i_n1 + i_n2] += carry;
        //        }
                
        //        //To shift position to left after every multiplication of a digit in num1.
        //        i_n1++;
        //    }
        //    //Ignore '0's from the right
        //    i = result.Count() - 1;
        //    while (i >= 0 && result[i] == 0)
        //    {
        //        i--;
        //    }
        //    //If all were '0's - means either both or one of num1 or num2 were '0'
        //    if (i == -1)
        //    {
        //        return "0";
        //    }

        //    //Generate the result string
        //    string s = "";
        //    while (i >= 0)
        //    {
        //        s += result[i--];
        //    }
        //    return s;
        //}
        //static void Main()
        //{
        //    string str1 = "11";
        //    string str2 = "10000";
        //    Console.WriteLine(multiply(str1, str2));
        //}
    }
}
