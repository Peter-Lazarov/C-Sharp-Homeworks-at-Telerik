using System;

    class Program
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            object whole = str1 + " " + str2;
            string str3 = (string)whole;
            Console.WriteLine(str3);
        }
    }
