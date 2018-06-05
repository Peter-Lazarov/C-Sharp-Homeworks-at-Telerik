using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsystem
{
    class CatSystemStart
    {
        static void Main()
        {
            var PeshoOwner = new Owner("Pesho", "Ivanov");
            var GoshoOwner = new Owner("Gosho", "Petrov");

            PeshoOwner.IncreaseAge();

            Console.WriteLine(PeshoOwner.Age);
            Console.WriteLine(PeshoOwner.FullName);

            var cat = new Cat(CatColor.Mixed);
            var anothercat = new Cat(CatColor.Black);
            var yetanothercat = new Cat(CatColor.Brown);

            PeshoOwner.AddCat(cat, "Maca");
            PeshoOwner.AddCat(anothercat, "Silvestyr");

            Console.WriteLine(PeshoOwner.AllCats);

            Printer.PrintCat(anothercat);

            //Struct exercise
            var tochka = new Point();
            tochka.X = 4.5M;
            tochka.Y = 18.9M;
            Console.WriteLine(tochka.GetCoordinates());

            //1:03:00
            var myList = new GenericList<int>();
            myList.Add(1);
            myList.Add(2);

            var cat2 = new Cat(CatColor.Black);
            var dog = new Dog();
            dog.SayBau();

            var aniList = new GenericList<Animal>();
            var dogList = new GenericList<Dog>();

            //1:30:00
            var min = Min<bool>(true, false);
            Console.WriteLine(min);

            var cat3 = new Animalsystem.Cat();


            //Idexer
            GenericList<int> myList2 = new GenericList<int>();
            myList2.Add(1);

            Console.WriteLine(myList2[0]);

            StringCouple myStrings = new StringCouple();
            myStrings.Add("pesho", "peshov");
            myStrings.Add("ivan", "ivanov");

            Console.WriteLine(myStrings["pesho"]);
            Console.WriteLine(myStrings["ivan"]);

            myStrings["pesho"] = "todorov";
            Console.WriteLine(myStrings["pesho"]);

            // 2:18:35

            //Operator Overload
            var firstCat = new Cat(CatColor.Brown);
            var secondCat = new Cat(CatColor.Black);

            var result = firstCat + secondCat;
            Console.WriteLine(result.Color);
        }


        public static string GetString<T>(object element)
        {
            return element.ToString();
        }

        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
