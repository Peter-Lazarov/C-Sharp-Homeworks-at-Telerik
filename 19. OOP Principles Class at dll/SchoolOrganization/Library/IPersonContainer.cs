using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public interface IPersonContainer
    {
        void AddPerson(Person name);

        IEnumerable<Person> AllPersons { get; }
    }
}
