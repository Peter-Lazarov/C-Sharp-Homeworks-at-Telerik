using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcats : Cats
    {
        public Tomcats() : base()
        {
        }
        public Tomcats(string name, int age) : base(name, age, "Male")
        {
        }
        public string Sound()
        {
            return "Murr, murr";
        }
    }
}
