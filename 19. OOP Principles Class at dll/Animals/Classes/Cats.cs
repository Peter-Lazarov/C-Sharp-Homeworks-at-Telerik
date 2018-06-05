using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cats : Animal, ISound
    {
        public Cats()
        {
            Animal.AllAnimals.Add(this);
        }
        public Cats(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            Animal.AllAnimals.Add(this);
        }
        public string Sound()
        {
            return "Meeau, meeeau";
        }
    }
}
