using System;

class Program
{
    static void Main()
    {
        string hex = "FE";
        byte num = byte.Parse(hex,System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(num);
        Console.WriteLine();
        string hextry = "FA";
        num = byte.Parse(hextry, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(num);
    }
}