using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsandWorkers
{
    public class Student : Human
    {
        public static List<Student> AllStudents = new List<Student>();
        public int grade { get; set; }

        public Student()
        {
        }
        public Student(string fname, string lname, int stgrade):base(fname, lname)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.grade = stgrade;
            AllStudents.Add(this);
        }
        public override string ToString()
        {
            string overWritten = string.Format("{0} {1} {2}", this.firstName, this.lastName, this.grade);
            return overWritten;
        }
    }
}
