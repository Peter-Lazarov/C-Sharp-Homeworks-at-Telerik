namespace PrinciplesPart2
{
    //using Animal;
    using System;
    public class PrincipalsEntryPoint
    {
        public static void Main()
        {
            IAnimal cat = new Cat("Pesho", 5);
            IAnimal dog = new Dog("Gosho", 6);
            Console.WriteLine(cat.Speak());
            Console.WriteLine(dog.Speak());


        }
    }
}
