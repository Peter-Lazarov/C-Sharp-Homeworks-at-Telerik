using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Student : Person 
    {
        public int classNumber { get; set; }

        public Student() : base()
        {
        }
        public Student(string fname, string lname, int classnum) : base(fname, lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
            this.classNumber = classnum;
        }
    }
}
