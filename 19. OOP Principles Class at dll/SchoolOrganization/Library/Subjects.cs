using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    public class Subjects : Comments
    {
        public string name { get; set; }
        public int lectures { get; set; }
        public int exercises { get; set; }

        public Subjects()
        {

        }
        public Subjects(string Name, int Lecture, int Exercise)
        {
            this.name = Name;
            this.lectures = Lecture;
            this.exercises = Exercise;
        }
    }
}
