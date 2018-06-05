using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forResearch
{
    class Supplier
    {
        public string name { get; set; }
        public string sell { get; set; }
        public static List<Supplier> Supply = new List<Supplier>();

        public Supplier()
        {
            Supply.Add(this);
        }
        public Supplier(string seller, string inventar)
        {
            this.name = seller;
            this.sell = inventar;
            Supply.Add(this);
        }
    }
}
