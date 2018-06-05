using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lecture
{
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(int age, string breed): base(age)
        {
            this.Breed = breed;
        }

        public override void Move()
        {
            Console.WriteLine("The dog is moving");
        }

        public void WagTail()
        {
            Console.WriteLine("Tail wagging...");
        }
    }
}
