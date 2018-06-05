using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Teacher : Employee
    {
        public List<Subjects> AllSubjects = new List<Subjects>();
        public Teacher() : base()
        {
        }
        public Teacher(string fname, string lname) : base(fname, lname)
        {
            base.FirstName = fname;
            base.LastName = lname;
        }
        public void AddSubject(string n, int lec, int exe)
        {
            this.AllSubjects.Add(new Subjects(n, lec, exe));
        }
    }
}
