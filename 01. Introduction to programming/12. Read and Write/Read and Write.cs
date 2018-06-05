using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Type your age");
        string y;
        y = Console.ReadLine();
        int i = Convert.ToInt32(y);
        Console.WriteLine(i + 10);
    }
}