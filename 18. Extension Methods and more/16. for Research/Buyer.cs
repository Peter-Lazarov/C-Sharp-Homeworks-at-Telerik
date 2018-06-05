using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forResearch
{
    class Buyer
    {
        public string name { get; set; }
        public string demand { get; set; }
        public static List<Buyer> Customers = new List<Buyer>();

        public Buyer()
        {
            Customers.Add(this);
        }
        public Buyer(string buyer, string shoppingList)
        {
            this.name = buyer;
            this.demand = shoppingList;
            Customers.Add(this);
        }
    }
}
