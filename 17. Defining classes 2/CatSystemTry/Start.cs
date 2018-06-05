using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatSystemTry
{
    class Start
    {
        static void Main()
        {
            Owner Pesho = new Owner("Pesho", "Lazarov");
            Cats Panny = new Cats("Kafiava");
            Panny.Sobstvenik = Pesho;
            Cats Kafiavoto = new Cats("Kafiavo i bialo");

            Pesho.AddKote(Kafiavoto, "Sharencho");
            Pesho.AddKote(Panny, "Panny");
            Pesho.All();
        }
    }
}
