using System;

    class Program
    {
        static void Main()
        {
            char c = '\u00A9';
            Console.WriteLine("  " + new string (c, 1));
            Console.WriteLine(" " + new string (c, 3));
            Console.WriteLine(new string(c, 5));
        }
    }
