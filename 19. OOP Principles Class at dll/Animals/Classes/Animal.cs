using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string sex;

        private string kind;

        public static List<Animal> AllAnimals = new List<Animal>();
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    this.sex = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Kind
        {
            get
            {
                if (this.GetType().BaseType.Name == "Animal")
                {
                    return this.GetType().Name;
                }
                else 
                {
                    return this.GetType().BaseType.Name;
                }
            }
        }

        //Try 1
        public static decimal AvgAge()
        {
            decimal avg = 0;
            int i;
            for (i = 0; i < AllAnimals.Count(); i++)
            {
                avg += AllAnimals[i].Age;
            }
            return avg/i;
        }
        public List<Animal> AvgAge2()
        {
            var byAnimalType =
                from anim in AllAnimals
                group anim by anim.GetType() into groupeAnim
                select new { AveregeAge = groupeAnim.Average(x => x.Age)};

            List<Animal> All = new List<Animal>();

            foreach (var a in byAnimalType)
            {
                //All.Add(a);
            }

            return All;
        }

        //Try 2
        public static string avgAgeOfAnimals(List<Animal> Animals)
        {
            var byAnimalType =
                from anim in Animals
                group anim by anim.Kind into grouped
                select new { animType = grouped.Key, avgAge = grouped.Average(x => x.Age) };

            string result = "";

            foreach (var item in byAnimalType)
            {
                result += string.Format(item.animType + " ");
                result += item.avgAge + "\r\n";
            }
            return result;
        }
    }
}
