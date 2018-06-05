using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    public class Bunny : Animal
    {
        private static int numberofLegs = 4; //This variable is common for all rabits. Obshto za vsiki zaici.

        const int InitialHealth = 200;//Constant-a
        const int InitialCarrots = 0;

        //string name;//This is field
        private string color;
        private ulong carrotsCount;

        public Bunny(string bunnyName)
        {
            this.Name = bunnyName;
            this.Health = InitialHealth;
            this.carrotsCount = InitialCarrots;
            this.IsRetire = false;
        }

        public Bunny(string bunnyName, string playerColor)
            : this(bunnyName)
        {
            this.color = playerColor;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value != "Blue" && value != "Red")
                {
                    throw new ArgumentException("Color must be Blue or Red");
                }
                this.color = value;
            }
        }

        public bool IsRetire { get; private set; }

        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }
        public void Retire()
        {
            if (this.Health < 0)
            {
                this.IsRetire = true;
            }
        }
        public int Damage
        {
            get
            {
                if (this.Health < 0)
                {
                    return InitialHealth;
                }

                int damage = InitialHealth - this.Health;
                return damage;
            }
        }
    }
}
