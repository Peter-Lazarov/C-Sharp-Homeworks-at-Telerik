using System;

class Program
{
    static void Main()
    {
        string hexs = "48";
        byte numm = byte.Parse(hexs, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(numm);
        char cha = Convert.ToChar(numm);
        Console.WriteLine(cha);
    }
}
