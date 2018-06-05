using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystemTry
{
    class Owner
    {
        private string firstName;
        private string lastName;

        List<Cats> koteta;
        public Owner(string First, string Last)
        {
            this.firstName = First;
            this.lastName = Last;
            //int Age = 0;
            this.koteta = new List<Cats>();
        }
        public void AddKote(Cats newkote, string newkoteime)
        {
            newkote.name = newkoteime;
            newkote.Sobstvenik = this;
            this.koteta.Add(newkote);
        }
        public void All()
        {
            string vsichkikoteta = "";
            foreach (var item in koteta)
            {
                vsichkikoteta = vsichkikoteta + item.name + " ";
            }
            Console.WriteLine("{0} {1}, {2}", this.firstName, this.lastName, vsichkikoteta);
        }
    }
}
