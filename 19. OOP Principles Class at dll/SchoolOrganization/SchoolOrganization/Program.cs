using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSystem;

namespace SchoolOrganization
{
    class Program
    {
        static void Main()
        {
            ////for Interfaces
            //var school = new School();

            //school.AddPerson("Ginka Ivanova");
            //school.AddPerson("Pesho Peshov");

            //foreach (var person in school.People)
            //{
            //    Console.WriteLine(person);
            //}

            Director dir = new Director("Gosho", "Dimitrov");
            Console.WriteLine(dir.FirstName);

            Teacher Pesho = new Teacher("Pesho", "Todorov");
            Pesho.Salary = 1000;
            
            Subjects geo = new Subjects("Geography", 20, 10);
            Pesho.AllSubjects.Add(geo);
            Pesho.AddSubject("Telemetria", 5, 10);

            Student Ivancho = new Student("Ivan", "Petrov", 9);
            Console.WriteLine(Ivancho.FirstName + " " +Ivancho.LastName);
        }
    }
}
