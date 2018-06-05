using System;
using System.Collections.Generic;
namespace Classes
{
  
    public class Student : ICloneable, IComparable<Student>
    {
        //first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty
        private string fname;
        private string mname;
        private string lname;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private Specialty speciality;
        private University university;
        private Faculty faculty;

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        
        public string Mname
        {
            get { return mname; }
            set { mname = value; }
        }
        
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Ssn
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Specialty Speciality
        {
            get { return speciality; }
            set { speciality = value; }
        }

        public University University
        {
            get { return university; }
            set { university = value; }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student()
        {
        }

        public Student(string fname, string mname, string lname, string ssn, string address, string phone, 
            string email, Specialty special, University uni, Faculty faculty)
        {
            this.fname = fname;
            this.mname = mname;
            this.lname = lname;
            this.ssn = ssn;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.speciality = special;
            this.university = uni;
            this.faculty = faculty;
        }

        public override bool Equals(object obj)
        {
            var objAsStudent = obj as Student;
            if (objAsStudent == null)
            {
                return false;
            }
            if (this.fname != objAsStudent.fname)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.fname.GetHashCode() ^ this.phone.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", this.fname, this.lname, this.ssn, this.phone, this.address, this.email, this.speciality, this.faculty, this.university);
        }

        public object Clone()
        {
            var newStudent = new Student();
            newStudent.fname = this.fname;
            newStudent.mname = this.mname;
            newStudent.lname = this.lname;

            newStudent.ssn = this.ssn;
            newStudent.phone = this.phone;
            newStudent.address = this.address;
            newStudent.email = this.email;
            newStudent.speciality = this.speciality;
            newStudent.faculty = this.faculty;
            newStudent.university = this.university;

            return newStudent;
        }

        public int CompareTo(Student otherStudent)
        {
            if ((string.Compare(this.fname, otherStudent.fname,StringComparison.Ordinal) <= 0))
            {
                if (Convert.ToInt32(this.ssn) < Convert.ToInt32(otherStudent.ssn))
                {
                    return -1;
    	        }
                else
                {
                    return 1;
                }
            }
            else if (string.Compare(this.fname, otherStudent.fname, StringComparison.Ordinal) > 0)
            {
                if (Convert.ToInt32(this.ssn) < Convert.ToInt32(otherStudent.ssn))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
