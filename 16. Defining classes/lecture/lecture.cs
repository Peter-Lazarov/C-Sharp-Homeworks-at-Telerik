using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    class lecture
    {
        //Simple a try
        //static void Main()
        //{
        //    Student studentReferencia = new Student();
        //    studentReferencia.firstName = "Pesho";
        //    studentReferencia.lastName = "Kolev";
        //    studentReferencia.facultyNumber = "112321321";

        //    Student secoundStudent = new Student();
        //}
        //class Student
        //{
        //    public string facultyNumber;
        //    public string firstName;
        //    public string lastName;
        //}

        //further try
        //static void Main()
        //{
        //    Student studentReferencia = new Student();
        //    studentReferencia.firstName = "Pesho";
        //    studentReferencia.lastName = "Kolev";
        //    studentReferencia.facultyNumber = "112321321";

        //    Student secoundStudent = new Student();
        //    studentReferencia.GoToClass();
        //}
        //class Student
        //{
        //    public string facultyNumber;
        //    public string firstName;
        //    public string lastName;

        //    public void GoToClass()
        //    {
        //        // Go to class
        //        // Sit on the desk
        //        // Listen to the lecturer
        //    }
        //}
        
        
        
    //    //Property part Start
    //    static void Main()
    //    {
    //        Student student = new Student();
    //        student.FirstName = "Pesho";
    //        student.MiddleName = "Kolev";
    //        student.LastName = "Kolev";
    //        Console.WriteLine(student.fullName);
    //        student.MiddleName = "Ganchev";
    //        Console.WriteLine(student.fullName);
    //    }
    //}
    //class Student
    //{
    //    private string firstName;
    //    private string middleName;
    //    private string lastName;

    //    public string FirstName 
    //    {
    //        set
    //        {
    //            if (value.Length >= 5)
    //            {
    //                this.firstName = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("First name must be more than five characters");
    //            }
    //        }
    //    }
    //    public string MiddleName
    //    {
    //        set
    //        {
    //            this.middleName = value;
    //        }
    //    }
    //    public string LastName
    //    {
    //        set
    //        {
    //            this.lastName = value;
    //        }
    //    }

    //    public string fullName 
    //    {
    //        get
    //        {
    //            return string.Format("{0} {1} {2}", firstName, middleName, lastName);
    //        }
    //    }
    //}
    ////Property part End
    
    ////Constants part Start
    //    static void Main()
    //    {
    //        int plantsSum = AndromedaGalaxy.PlanetCount + MilkyWayGalaxy.PlanetCount;
    //    }
    //}
    //class AndromedaGalaxy
    //{
    //    public const int PlanetCount = 1928;
    //}
    //class MilkyWayGalaxy
    //{
    //    public const int PlanetCount = 8;
    //}
    ////Constants part End

    ////Constructors part Start
    //    static void Main()
    //    {
    //        Person chovek = new Person("Pesho", 20);
    //        Console.WriteLine(chovek.Name);
    //    }
    //}
    //class Person
    //{
    //    private string name;
    //    private int age;

    //    public Person(string name, int age)
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }

    //    public string Name
    //    {
    //        get
    //        {
    //            return this.name;
    //        }
    //    }
    //    public int Age
    //    {
    //        get
    //        {
    //            return this.age;
    //        }
    //    }
    //}
    ////------------------------------------------------------------- part End

    ////Interface part Start
    //    static void Main()
    //    {
    //        IPerson person = new Person();
    //    }
    //}
    //public class Person : IPerson
    //{
    //    public string FullName { get; set; }
    //    public string HairColor { get; set; }
    //}
    //public interface IPerson
    //{
    //    string FullName { get; set; }
    //    string HairColor { get; set; }

    //}
    ////------------------------------------------------------------- part End
        
        
        
        //Start ----------------------------------------------------
        static void Main()
        {
            IPerson person = new Person();
        }
    }
    public class Person : IPerson
    {
        public string FullName { get; set; }
        public string HairColor { get; set; }
    }
    public interface IPerson
    {
        string FullName { get; set; }
        string HairColor { get; set; }

    }
    //------------------------------------------------------------- part End
}
