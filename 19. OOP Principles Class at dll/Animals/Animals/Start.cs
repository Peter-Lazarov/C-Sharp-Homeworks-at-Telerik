using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Start
    {
        static void Main()
        {
            //Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
            //Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). All animals are described by age, name and sex.
            //Kittens and tomcats are cats. Kittens can be only female and tomcats can be only male. 
            //Each animal produces a specific sound.

            //Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
            Dog sharo = new Dog("Sharo", 5, "Male");
            Dog jony = new Dog("Jony", 3, "Male");
            //sharo.Sound();
            Cats maumau = new Cats("Maumau", 4, "Female");
            //maumau.Sound();
            Kittens smallMeau = new Kittens("Lili", 1);
            Tomcats tomy = new Tomcats("Tomy", 1);
            Frogs greeny = new Frogs("Greeny", 7, "Male");
            //Age averege try 1 (that was missunderstanding) calculate average to all animals
            //Console.WriteLine(Animal.AvgAge());

            ////GetType testing (zaigravka)
            //Console.WriteLine(sharo.GetType().BaseType); //Animals.Animal
            //Console.WriteLine(sharo.GetType().FullName); //Animals.Dog
            //Console.WriteLine(tomy.GetType().BaseType); //Animals.Cats
            //Console.WriteLine(tomy.GetType().BaseType.Name); //Cats
            //Console.WriteLine(sharo.GetType().BaseType.Name); //Animal
            //Console.WriteLine(sharo.GetType().Name); //Dog
            
            ////GetType testing (zaigravka) prodaljenito
            //Console.WriteLine(sharo.Kind);
            //Console.WriteLine(tomy.Kind);
            //Console.WriteLine(smallMeau.Kind);
            //Console.WriteLine(maumau.Kind);

            //Dogs 4
            //Cats 5
            //Frogs 6
            //var byAnimalType =
            //    from anim in Animal.AllAnimals
            //    group anim by anim.Kind into grouped
            //    select new { animType = grouped.Key, avgAge = grouped.Average(x => x.Age) };

            //foreach (var item in byAnimalType)
            //{
            //    Console.Write(item.animType + " ");
            //    Console.WriteLine(item.avgAge);
            //}

            //Problem 3. Animal hierarchy
            string a = Animal.avgAgeOfAnimals(Animal.AllAnimals);

            Console.WriteLine(a);
        }
    }
}
