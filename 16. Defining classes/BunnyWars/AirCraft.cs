using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class AirCraft
    {
        public static double CalculateDistance(AirCraft first, AirCraft secound)
        {
            return Math.Sqrt(
                (first.Coordinates.X - secound.Coordinates.X) * (first.Coordinates.X - secound.Coordinates.X) +
                (first.Coordinates.Y - secound.Coordinates.Y) * (first.Coordinates.Y - secound.Coordinates.Y)
                );
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public Bunny Pilot { get; private set; }

        public int Damage { get; set; }

        public Map Coordinates { get; private set; }

        public AirCraft(Bunny bunny, int damage)
        {
            this.Pilot = bunny;
            this.Damage = damage;
            this.Coordinates = new Map();
        }

        public void Attack(AirCraft target)
        {
            target.Pilot.Health -= this.Damage;
        }

        public void Move(Map coor)
        {
            this.Coordinates.X = coor.X;
            this.Coordinates.Y = coor.Y;
        }
    }
}
