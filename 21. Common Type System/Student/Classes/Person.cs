using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Person(string name, int? age = null)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            if (this.age == null)
            {
                return string.Format("{0} {1}", this.name, "Age is not specified");
            }
            else
            {
                return string.Format("{0} {1}", this.name, this.age);
            }
        }
    }
}
