using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main()
        {
            ////Problem 3. First before last
            ////Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            ////Use LINQ query operators.

            //Students Pesho = new Students("Pesho", "Lazarov");
            //Students Ivan = new Students("Ivan", "Todorov");
            //Students Vankata = new Students("Ivan", "Marianov");

            //var nameQuery =
            //    from stud in Students.Vsichki
            //    where Students.Letter(stud.firstName) < Students.Letter(stud.lastName)
            //    select stud;

            //foreach (var stud in nameQuery)
            //{
            //    Console.WriteLine("{0} {1}", stud.firstName, stud.lastName);
            //}

            //int a = (int)Ivan.firstName.ToLower().First();
            //int b = (int)Ivan.lastName.ToLower().First();
            //if (a < b)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine("Yeah");
            //}
            //else
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //    Console.WriteLine("Nooo");
            //}
            ////------------------------------------------------------------------------------------

            ////Problem 4. Age range
            ////Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

            //Students Pesho = new Students("Pesho", "Lazarov", 22);
            //Students Ivan = new Students("Ivan", "Todorov", 24);
            //Students Vankata = new Students("Ivan", "Marianov", 25);

            //var ageQuery =
            //    from stud in Students.Vsichki
            //    where (17 < stud.age) && (stud.age < 25)
            //    select stud;

            //foreach (var stud in ageQuery)
            //{
            //    Console.WriteLine("{0} {1} {2}", stud.firstName, stud.lastName, stud.age);
            //}
            ////------------------------------------------------------------------------------------

            ////Problem 5. Order students
            ////Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students 
            ////by first name and last name in descending order.
            ////Rewrite the same with LINQ.

            Students Pesho = new Students("Pesho", "Lazarov", 22);
            Students Ivan = new Students("Ivan", "Todorov", 24);
            Students Vankata = new Students("Ivan", "Marianov", 25);

            var sortedStudents =
                from stud in Students.Vsichki
                orderby stud.firstName, stud.lastName
                select stud;

            foreach (var stud in sortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", stud.firstName, stud.lastName, stud.age);
            }

            var ordered = Students.Vsichki.OrderBy(x => x.firstName).ThenBy(x => x.lastName);
            //Descending
            //var ordered = Students.Vsichki.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);

            ////--------------------------------------------------------------------------------------------
            //Problem 6. Order students
            //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

            //List<int> numbers = new List<int> { 1, 42, 21, 84 };
            ////Lambda part
            ////List<int> selected = numbers.FindAll(n => (n % 3 == 0) && (n % 7 == 0));
            
            ////LINQ part
            //var selectedNums =
            //    from num in numbers
            //    where num % 3 == 0 && num % 7 == 0
            //    //select num % 3 == 0 && num % 7 == 0;
            //    select num;           
        }
    }
}
