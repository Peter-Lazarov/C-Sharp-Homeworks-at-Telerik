using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catsystem
{
    [Required]
    public class Cat
    {
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }

        public Cat(CatColor color)
        {
            this.Color = color;
        }
        
        //Fields
        public string Name { get; set; }
        public int Age { get; private set; }
        public Owner Owner { get; set; }
        public CatColor Color { get; private set; }

        public Gender Sex { get; private set; }

        public static string WhatDoesTheCatSay()
        {
            return "Mew!";
        }

        public static Cat operator +(Cat first, Cat second)
        {
            if (first.Sex == Gender.Male && second.Sex == Gender.Female)
            {
                if (first.Color == second.Color)
                {
                    return new Cat(first.Color);
                }
                return new Cat(CatColor.Mixed);
            }
            throw new ArgumentException();
        }

        private void GenrateGender()
        {
            var randowm = new Random();

            var random = new Random();
            var genderIndex = random.Next(0, 2);
            this.Sex = (Gender)genderIndex;
        }
    }
}
