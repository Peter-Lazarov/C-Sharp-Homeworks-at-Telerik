namespace forTry
{
    using System;
    class StartPoint
    {
        static void Main()
        {
            Pine bortree = new Pine(5);

            Console.WriteLine(bortree.Height);
            bortree.Grow();
            Console.WriteLine(bortree.Height);
            Console.WriteLine(bortree.ShisharkaDrop());
        }
    }
}
