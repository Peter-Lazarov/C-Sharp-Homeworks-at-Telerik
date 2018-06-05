using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lecture
{
    class Startfile
    {
        static void Main()
        {
            Dog joe = new Dog(8, "Labrador");
            Cat kitty = new Cat(10);

            joe.Move();
            kitty.Move();
            kitty.Sleep();
            
            //joe.Sleep();
            //joe.WagTail();
            //Console.WriteLine("Joe is {0} years old dog of breed {1}.",
            //    joe.Age, joe.Breed);

            //Console.WriteLine();

            //Cat dolly = new Cat(3);
            //dolly.Sleep();
            //dolly.SayMyaau();
            //Console.WriteLine("Dolly is {0} years old cat.", dolly.Age);
            Console.WriteLine();
            Mammal[] Mammals = { joe, kitty};

            foreach (var item in Mammals)
            {
                item.Move();
            }
        }
    }
}
