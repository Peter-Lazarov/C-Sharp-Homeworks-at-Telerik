using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frogs : Animal, ISound
    {
        public Frogs()
        {
            Animal.AllAnimals.Add(this);
        }
        public Frogs(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            Animal.AllAnimals.Add(this);
        }
        public string Sound()
        {
            return "Crock, crock";
        }
    }
}
