using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Person : Comments
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Talk(string speech)
        {
            Console.WriteLine(speech);
        }
        public Person()
        {
            School.people.Add(this);
        }
        public Person(string firstN, string lastN)
        {
            this.FirstName = firstN;
            this.LastName = lastN;
            School.people.Add(this);
        }
    }
}
