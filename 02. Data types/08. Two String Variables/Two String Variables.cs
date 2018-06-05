using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"With \"" and \""");
            string first = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(first);
            Console.WriteLine();
            Console.WriteLine("Wiht @\" \"");
            string secound = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(secound);
        }
    }
