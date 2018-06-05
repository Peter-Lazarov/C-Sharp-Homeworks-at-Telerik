namespace PrinciplesPart2
{
    using System;
    public abstract class Animal : IAnimal
    {
        public Animal(int age)
        {
            this.Age = age;
        }

        //protected - naslednicite mogat da go promeniat
        public string Name { get; protected set; }

        public int Age 
        {
            get
            {
                return this.Age;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new InvalidAnimalAgeExeption("Wrong number for age");
                }
                if (value > 10)
                {
                    throw new InvalidAnimalAgeExeption("Wrong number for age");
                }
            }
        }

        //virual methods moje da budat promeniani ot naslednicite
        public virtual string Speak()
        {
            //return "I am animal!";
            return "{0} says ";
        }
    }
}
