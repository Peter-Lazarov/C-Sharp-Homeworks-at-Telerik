using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.User_choise_int__double__string
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose (i)nt, (d)ouble or (s)tring, will input");
            string user;
            user = Console.ReadLine();
            
            switch (user)
            {
                case "i":
                    int value;
                    Console.WriteLine("Enter your value");
                    value = Convert.ToInt32(Console.ReadLine());
                    value = value + 1;
                    Console.WriteLine("Your result is {0}", value);
                    break;
                case "d":
                    double dvalue;
                    Console.WriteLine("Enter your value");
                    dvalue = Convert.ToDouble(Console.ReadLine());
                    dvalue = dvalue + 1;
                    Console.WriteLine("Your result is {0}", dvalue);
                    break;
                case "s":
                    string svalue;
                    Console.WriteLine("Enter your value");
                    svalue = Console.ReadLine();
                    svalue = svalue + "*";
                    Console.WriteLine("Yor word is {0}", svalue);
                    break;
                default:
                    break;
            }
        }
    }
}
