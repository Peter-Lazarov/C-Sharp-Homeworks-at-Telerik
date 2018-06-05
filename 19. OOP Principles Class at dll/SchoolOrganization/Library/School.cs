using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class School //: IPersonContainer
    {
        public static List<Person> people = new List<Person>();

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public IEnumerable<Person> People
        {
            get
            {
                return this.People;
            }
        }
    }
}
