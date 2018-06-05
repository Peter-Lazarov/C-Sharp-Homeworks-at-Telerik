namespace Bunnies
{
    using System;
    public abstract class Animal // abstract class cannot be initialised
    {
        //private readonly string name;//We change field to readonly
        private string name;//We change field to readonly
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Name must be longar than 6 symbols");
                }
                this.name = value;
            }
        }
        public int Health { get; set; }
    }
}
