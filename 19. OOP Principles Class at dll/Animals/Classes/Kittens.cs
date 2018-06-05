using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kittens : Cats
    {
        public Kittens() : base()
        {
        }
        public Kittens(string name, int age) : base(name, age, "Female")
        {
        }
        public string Sound()
        {
            return "Me ual";
        }
    }
}
