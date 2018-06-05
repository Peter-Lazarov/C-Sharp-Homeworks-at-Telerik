using System;

class MainClass
{
    static void Main()
    {
        for (int x = 2; x <= 10; x++)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x * (-1));
            }
        }
    }
}