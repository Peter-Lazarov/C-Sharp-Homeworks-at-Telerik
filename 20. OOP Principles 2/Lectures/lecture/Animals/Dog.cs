namespace PrinciplesPart2
{
    public class Dog : Animal, IAnimal
    {
        public Dog(string name, int age) : base(age)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string Speak()
        {
            //return AnimalUtils.FormatSaying(this.Name, "BAU");
            //return string.Format(base.Speak() + "BAU", this.Name);
            return "BAU";
        }
    }
}
