using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Binary_floating_point
{
    class Program
    {
        // static long[] DectoBin(long dec)
        //{
        //    long[] bin = new long[32];
        //    int i = 0;

        //    while (dec > 0)
        //    {
        //        bin[i] = dec % 2;
        //        dec /= 2;
        //        i++;
        //    }
        //    long[] ready = new long[i];
        //    Array.Copy(bin, ready, i);
        //    Array.Reverse(ready);
        //    return ready;
        //}
        //static void Main()
        //{
            
        //    double number = 975.75;
        //    long wholenum = (long)number;
        //    long max = 2147483648;
        //    string binary = "";
        //    string sign = "";
        //    long []binnum = new long[32];

        //    if (wholenum > 0)
        //    {
        //        binnum = DectoBin(wholenum);
        //        binary = (String.Join("",binnum));
        //    }
        //    else if (wholenum == 0)
        //    {
        //        binary = (String.Join("", DectoBin(0)));
        //    }
        //    else if (wholenum < 0)
        //    {
        //        wholenum = max + wholenum;
        //        binnum = DectoBin(wholenum);
        //        binnum[0] = 1;
        //        binary = (String.Join("", binnum));
        //    }

        //    int comma = number.ToString().Length - number.ToString().IndexOf(",");
        //    int right = (int)(((decimal)number % 1) * (int)Math.Pow(10, comma));

        //    int exponent = binary.Length - 1;
        //    exponent += 127;
        //    string expo = String.Join("", DectoBin(exponent));
        //    exponent = binary.Length - 1;

        //    Building mantisa
        //    string mantisa = binary.Remove(0, 1);
        //    for (int i = 0; i < number.ToString().IndexOf(","); i++)
        //    {
        //        if ( right.ToString()[i] - '0' >= 5)
        //        {
        //            mantisa += "1";
        //        }
        //        else
        //        {
        //            mantisa += "0";
        //        }
        //    }
        //    Calculating mantisa value
        //    decimal mantisaint = 0;
        //    for (int a = 0; a < mantisa.Length-1; a++)
        //    {
        //        mantisaint += (decimal)(mantisa[a] - '0') * ((decimal)Math.Pow(2, -a - 1));
        //    }
        //    if (mantisaint < 1)
        //    {
        //        mantisaint++;
        //    }
        //    for (int j = mantisa.Length; j < 23; j++)
        //    {
        //        mantisa += "0";
        //    }
        //    number = (double)Math.Pow(2, exponent) * (double)mantisaint;

        //    Console.WriteLine(expo);
        //    Console.WriteLine(mantisa);
        //    Console.WriteLine(number);

        //Knowledge from this video https://www.youtube.com/watch?v=QtN7l3nlkhs

        static long[] DectoBin(long dec)
        {
            long[] bin = new long[32];
            int i = 0;

            while (dec > 0)
            {
                bin[i] = dec % 2;
                dec /= 2;
                i++;
            }
            long[] ready = new long[i];
            Array.Copy(bin, ready, i);
            Array.Reverse(ready);
            return ready;
        }
        static double Right(double number)
        {
            int comma = number.ToString().Length - 1 - number.ToString().IndexOf(",");
            double right = (double)number % 1;
            return right;
        }
        static void Main()
        {

            double number = -21.15625; //975.75;

            long wholenum = (long)number;
            
            //long max = 2147483648;
            string binary = "";
            string sign = "";
            long[] binnum = new long[32];

            if (wholenum == 0)
            {
                binary = (String.Join("", binnum));
            }
            else
            {
                if (wholenum > 0)
                {
                    sign = "0";
                }
                else
                {
                    sign = "1";
                }
                number = Math.Abs(number);
                wholenum = Math.Abs(wholenum);
                binary = (String.Join("", DectoBin(wholenum)));

                int exponent = binary.Length - 1;
                exponent += sign[0] - '0' + 127 + sign[0] - '0';
                string expo = String.Join("", DectoBin(exponent));
                exponent = binary.Length - 1;

                //Get right side of number
                double right = Right(number);

                double ex = 1;
                //Building mantisa
                string mantisa = binary.Remove(0, 1);
                string vreme = "";
                for (int i = 0; (ex > 0) && (mantisa.Length < 23); i++)//number.ToString().IndexOf(",")
                {
                    ex = right * 2;
                    right = Right(ex);
                    if (ex >= 1)
                    {
                        mantisa += "1";
                        vreme += "1";
                    }
                    else
                    {
                        mantisa += "0";
                        vreme += "0";
                    }
                }
                //Calculating mantisa value
                decimal mantisaint = 0;
                for (int a = 0; a < mantisa.Length - 1; a++)
                {
                    mantisaint += (decimal)(mantisa[a] - '0') * ((decimal)Math.Pow(2, -a - 1));
                }
                if (mantisaint < 1)
                {
                    mantisaint++;
                }
                for (int j = mantisa.Length; j < 23; j++)
                {
                    mantisa += "0";
                }
                number = (double)Math.Pow(2, exponent) * (double)mantisaint;

                Console.WriteLine(expo);
                Console.WriteLine(mantisa);
                Console.WriteLine(number);

                Console.WriteLine("{0} {1} {2}", sign, expo, mantisa);
            }
        }
    }
}
