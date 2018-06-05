using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public Employee() : base()
        {
        }
        public Employee(string fname, string lname) : base(fname, lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
        }
    }
}
