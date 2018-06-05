using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lecture
{
    public class Cat : Mammal
    {
        public Cat(int age): base(age)
        {

        }
        public void SayMyaau()
        {
            Console.WriteLine("Myaau...");
        }
        public override void Move()
        {
            Console.WriteLine("The cat is moving");
        }
    }
}
