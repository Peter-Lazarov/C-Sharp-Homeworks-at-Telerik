using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public static List<Students> Vsichki = new List<Students>();

        public Students()
        {
            Vsichki.Add(this);
        }
        public Students(string fname, string lname, int age = 0)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.age = age;
            Vsichki.Add(this);
        }
        public static int Letter(string input)
        {
            return (int)input.ToLower().First();
        }
    }
}
