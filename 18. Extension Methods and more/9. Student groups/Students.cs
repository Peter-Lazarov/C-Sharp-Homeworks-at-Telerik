using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGroups
{
    public class Students
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public List<double> marks {get;set;}
        public string email { get; set; }
        public string phones { get; set; }
        public int groups { get; set; }

        public static List<Students> All = new List<Students>();

        public Students()
        {
            All.Add(this);
        }
        public Students(string fname, string lname, int age, List<double> mark, string mail, string phone, int group)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.age = age;
            this.marks = mark;
            this.groups = group;
            this.phones = phone;
            this.email = mail;
            All.Add(this);
        }
        public static string emailDomain(Students name)
        {
            int at = name.email.IndexOf('@') + 1;
            return name.email.Substring(at);
        }
        public static string phoneCode(Students name, int codeLength)
        {
            return name.phones.Substring(0, codeLength);
        }
    }
}
