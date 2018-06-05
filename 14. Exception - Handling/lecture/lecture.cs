using System;

namespace lecture
{
    class lecture
    {
        static void Main()
        {
            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int result = 10 / a;
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input is not digit!");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You cannot enter zero!");
            //}

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int result = 10 / a;
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You cannot enter zero!");
            //}

            ////Creating exception
            //try
            //{
            //    int a = 10;
            //    if (a == 10)
            //    {
            //        throw new ArgumentException("Poroba");
            //    }
            //    int result = 10 / a;
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            ////Collect multi exceptions maybe not working
            //try
            //{
            //    int a = int.Parse("10");
            //    if (a == 10)
            //    {
            //        throw new FormatException("Exception one");
            //    }
            //    int result = 10 / a;
            //}
            //catch (Exception ex)
            //{
            //    throw new IndexOutOfRangeException("Sorry!", ex);
            //}

            ////Re-Throwing Exceptions
            //string str = "proba";
            //try
            //{
            //    Int32.Parse(str);
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Parse Failed!");
            //    throw fe; //Re-throw the caught exception
            //}

        }
    }
}
