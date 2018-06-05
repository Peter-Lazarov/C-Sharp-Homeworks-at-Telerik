using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forResearch
{
    class Research
    {
        static void Main()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause

            Supplier Ivan = new Supplier("Ivan", "kashkaval");
            Supplier Gosho = new Supplier("Gosho", "maslo");

            Buyer Pesho = new Buyer("Pesho", "kashkaval");
            Buyer Pepy = new Buyer("Pepy", "sirene");
            Buyer Ivcho = new Buyer("Ivcho", "maslo");
            Buyer Elena = new Buyer("Elena", "shokolad");

            var innerJoin =
                from invent in Supplier.Supply
                join shopList in Buyer.Customers on invent.sell equals shopList.demand
                select new { Seller = invent.name, Good = invent.sell, Buyier = shopList.name};

            foreach (var item in innerJoin)
            {
                Console.WriteLine("{0} sold one {1} to {2}", item.Seller, item.Good, item.Buyier);
            }
        }
    }
}
