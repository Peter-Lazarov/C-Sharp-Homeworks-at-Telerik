namespace BunnyWars
{
    using System;
    using Bunnies;
    using System.Collections.Generic;

    class BunnyWarsMain
    {
        static void ChangeBunny(Bunny bunny)
        {
            bunny.Health = 0;
        }
        static void Main()
        {
            Bunny vankataBunny = new Bunny("Vankata");
            ulong currentVankataCarrots = vankataBunny.AddCarrots(100);
            Console.WriteLine(currentVankataCarrots);

            Bunny peshoBunny = new Bunny("Pesho", "Zelen");
            ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);
            Console.WriteLine(currentPeshoCarrots);

            vankataBunny.Color = "Blue";

            Console.WriteLine(vankataBunny.IsRetire);

            vankataBunny.Retire();
            vankataBunny.Health -= 250;
            vankataBunny.Retire();

            Console.WriteLine(vankataBunny.IsRetire);

            string empty = null;
            string secoundString = empty ?? "Full";
            Console.WriteLine(secoundString);

            Bunny baiGosho = new Bunny("Goshooooo");
            ChangeBunny(baiGosho);
            Console.WriteLine(baiGosho.Health);

            //List<Bunny> bunnies = new List<Bunny>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Bunny currentBunny = new Bunny(new string((char)i,10));
            //    bunnies.Add(currentBunny);
            //}
            //foreach (var item in bunnies)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var vankataAndPesho = new List<Bunny>
            {
                vankataBunny,
                peshoBunny
            };

            foreach (var item in vankataAndPesho)
            {
                Console.WriteLine(item.Name);
            }

            AirCraft firstAirCraft = new AirCraft(vankataBunny, 50);
            AirCraft secondAirCraft = new AirCraft(peshoBunny, 100);

            firstAirCraft.Attack(secondAirCraft);
            Console.WriteLine(secondAirCraft.Pilot.Health);

            firstAirCraft.Move(new Map(15, 20));
            secondAirCraft.Move(new Map(25, 40));

            double distance = AirCraft.CalculateDistance(firstAirCraft, secondAirCraft);

            Console.WriteLine(distance);

            Console.WriteLine(vankataBunny.Damage);
            ColorType color = ColorType.Red;
        }
    }
}
