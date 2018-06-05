using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsandWorkers
{
    class Program
    {
        static void Main()
        {
            //Define abstract class Human with a first name and a last 
            //name. Define a new class Student which is derived from 
            //Human and has a new field – grade. Define class Worker 
            //derived from Human with a new property WeekSalary and 
            //WorkHoursPerDay and a method MoneyPerHour() that returns 
            //money earned per hour by the worker. Define the proper 
            //constructors and properties for this hierarchy.
            
            //Initialize a list of 10 students and sort them by grade in 
            //ascending order (use LINQ or OrderBy() extension method).
            
            Student pesho = new Student("Pesho", "Lazarov", 4);
            Student todor = new Student("Todor", "Lazarov", 4);
            Student ivan = new Student("Vancho", "Todorov", 6);
            Student goshko = new Student("Goshko", "Lazarov", 6);
            Student spas = new Student("Spas", "Lazarov", 7);
            Student nikolay = new Student("Nikolay", "Lazarov", 7);
            Student peshot = new Student("Pesho", "Todorov", 5);

            var byGrade =
            from stud in Student.AllStudents
            orderby stud.grade
            select stud;

            foreach (Student st in byGrade)
            {
                Console.WriteLine(st.ToString());
            }

            //Initialize a list of 10 workers and sort them by money 
            //per hour in descending order.
            //Merge the lists and sort them by first name and last name.
            Console.WriteLine();
            Worker ivanw = new Worker("Ivan", "Rabotnikov", 400, 8);
            Worker peshow = new Worker("Pesho", "Zavarkata", 500, 8);
            Worker todorw = new Worker("Todor", "Batkata", 450, 6);
            Worker spasw = new Worker("Spas", "Kamazov", 300, 8);
            Worker nikolayw = new Worker("Nikolay", "Korabov", 600, 8);
            Worker goshow = new Worker("Georgi", "Strugarov", 350, 6);
            Worker kalinw = new Worker("Kalin", "Nachalnikov", 700, 6);
            
            var byMoneyforH =
                from work in Worker.AllWorkers
                orderby work.MoneyPerHour() descending
                select work;
            
            foreach (Worker wk in byMoneyforH)
            {
                Console.WriteLine(wk.ToString());
            }
            Console.WriteLine();

            var joinQueries =
                Student.AllStudents.Cast<Human>()
                .Concat(Worker.AllWorkers).ToList();

            var sorted =
                from hum in joinQueries
                orderby hum.firstName
                select hum;

            foreach (var human in sorted)
            {
                Console.WriteLine(human.firstName + " " +human.lastName);
            }
        }
    }
}
