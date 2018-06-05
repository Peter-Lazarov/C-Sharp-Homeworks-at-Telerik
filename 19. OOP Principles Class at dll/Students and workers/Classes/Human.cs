using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsandWorkers
{
    public abstract class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Human()
        {
        }
        public Human(string fname, string lname)
        {
            this.firstName = fname;
            this.lastName = lname;
        }

    }
}
