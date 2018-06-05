using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal, ISound
    {
        public Dog()
        {
            Animal.AllAnimals.Add(this);
        }
        public Dog(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            Animal.AllAnimals.Add(this);
        }
        public string Sound()
        {
            return "Bau bau";
        }
    }
}
