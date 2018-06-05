namespace PrinciplesPart2
{
    public class Cat : Animal, IAnimal
    {
        public Cat(string name, int age): base(age)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string Speak()
        {
            //return string.Format("{0} says MYAU!!!", this.Name);

            //return string.Format(base.Speak() + "MIAU", this.Name);
            return "MIAU";
        }
    }
}
