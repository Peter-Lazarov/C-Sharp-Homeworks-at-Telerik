using System;

class Program
{
    static void Main()
    {
        float i = 0.000001F;
        double a = 5.3D;
        double b = 6.01D;
        Console.WriteLine(a);
        Console.WriteLine(b);
        double c = Math.Abs(a - b);
        if (c > i)
        {
            Console.WriteLine ("False");
        }
        else
        {
            Console.WriteLine ("True");
        }
        Console.WriteLine();
        double d = 5.00000001D;
        double e = 5.00000003D;
        Console.WriteLine(d);
        Console.WriteLine(e);

        c = Math.Abs(d - e);
        if (c > i)
        {
            Console.WriteLine ("False");
        }
        else
        {
            Console.WriteLine("True");
        }
    }
}
