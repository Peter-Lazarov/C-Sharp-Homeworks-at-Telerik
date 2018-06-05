using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Director : Employee
    {
        public Director() : base()
        {
        }
        public Director(string fname, string lname): base(fname, lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
        }

        public void FireEmployee()
        {
        }
        public void CallForMeeting()
        {
        }
    }
}
