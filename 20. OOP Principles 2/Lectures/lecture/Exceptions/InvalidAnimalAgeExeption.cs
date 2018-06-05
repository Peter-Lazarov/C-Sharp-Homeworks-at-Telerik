namespace PrinciplesPart2
{
    using System;
    class InvalidAnimalAgeExeption : ApplicationException
    {
        public InvalidAnimalAgeExeption(string msg) : base(msg)
        {
        }
    }
}
