using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_lecture
{
    public class Mammal : IMoveable, IMyau, IActionable
    {
        public int Age { get; set; }

        public Mammal(int age)
        {
            this.Age = age;
        }

        public void Sleep()
        {
            Console.WriteLine("Shhh! I'm sleeping!");
        }

        public virtual void Move()
        {
            Console.WriteLine("I am mammal and I am moving");
        }

        public void Myau()
        {
            throw new NotImplementedException();
        }
    }

    public interface IMoveable
    {
        void Move();
    }

    public interface IActionable
    {
        void Move();
    }

    public interface IMyau
    {
        void Myau();
    }
}
