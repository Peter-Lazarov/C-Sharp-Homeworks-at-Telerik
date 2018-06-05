using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGroups
{
    class StartFile
    {
        static void Main()
        {
            //9. Student groups
            //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            //Create a List<Student> with sample students. Select only the students that are from group number 2.
            //Use LINQ query. Order the students by FirstName.

            //10. Student groups extensions
            //Implement the previous using the same query expressed with extension methods.
            
            //11. Extract students by email
            //Extract all students that have email in abv.bg.
            //Use string methods and LINQ.

            //12. Extract students by phone
            //Extract all students with phones in Sofia.
            //Use LINQ.

            //13. Extract students by marks
            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
            //Use LINQ.

            //14. Extract students with two marks
            //Write down a similar program that extracts the students with exactly two marks "2".
            //Use extension methods.

            //16.* Groups
            //Create a class Group with properties GroupNumber and DepartmentName.
            //Introduce a property GroupNumber in the Student class.
            //Extract all students from "Mathematics" department.
            //Use the Join operator.

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause

            List<double> ocenkiPesho = new List<double> { 5, 4, 6, 5.5, 5 };
            List<double> ocenkiVancho = new List<double> { 3, 2, 5, 3.5, 6 };
            List<double> ocenkiGosho = new List<double> { 4, 5, 5, 5.5, 6 };
            List<double> ocenkiSrednoNivo = new List<double> { 4, 3, 3, 4, 5 };
            List<double> ocenkiSlaboNivo = new List<double> { 3, 2, 2, 4, 3 };

            Students Pesho = new Students("Pesho", "Lazarov", 31, ocenkiPesho, "pesho@gmail.com", "02106020", 2);
            Students Ivan = new Students("Ivan", "Todorov", 30, ocenkiVancho, "vankata@abv.bg", "092106020", 1);
            Students Gosho = new Students("Georgi", "Ivanov", 32, ocenkiSlaboNivo, "iakia@abv.bg", "02106020", 2);
            Students Gosho2 = new Students("Georgi", "Marianov", 28, ocenkiSlaboNivo, "neshtodaima@abv.bg", "02106020", 2);
            Students Marian = new Students("Marian", "Marinov", 29, ocenkiSrednoNivo, "marian@gmail.com", "0221020", 1);

            ////09.
            //var groupTry =
            //    from stud in Students.All
            //    where stud.groups == 2
            //    select stud;

            //foreach (var item in groupTry)
            //{
            //    Console.WriteLine("{0} {1} {2}", item.firstName, item.lastName, item.groups);
            //}

            //var groupTwo =
            //    from stud in Students.All
            //    where stud.groups == 2
            //    orderby stud.firstName
            //    select stud;

            //Console.WriteLine();
            //foreach (var item in groupTwo)
            //{
            //    Console.WriteLine("{0} {1} {2}", item.firstName, item.lastName, item.groups);
            //}

            ////10. 
            //Console.WriteLine();
            //Console.WriteLine("From here 10. exercise began");

            //foreach (var item in Students.All.byGroup(2))
            //{
            //    Console.WriteLine("{0} {1} {2}", item.firstName, item.lastName, item.groups);
            //}

            //11.
            //var abvEmail =
            //    from stud in Students.All
            //    where Students.emailDomain(stud) == "abv.bg"
            //    select stud;

            //foreach (var item in abvEmail)
            //{
            //    Console.WriteLine("{0} {1} {2}", item.firstName, item.lastName, item.email);
            //}
            //12.
            //var phonesSofia =
            //    from stud in Students.All
            //    where Students.phoneCode(stud, 2) == "02"
            //    select stud;

            //foreach (var item in phonesSofia)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", item.firstName, item.lastName, item.email, item.phones);
            //}

            ////13.
            //var excellents =
            //    from studs in Students.All
            //    where studs.marks.Max() > 5
            //    select studs;

            ////var newAnonimus = excelents.ToList()[0];
            //var newAnonimus = new[] {new{ fullName = excellents.ElementAt(0).firstName + " " + excellents.ElementAt(0).lastName, marks = excellents.ElementAt(0).marks},
            //                        new{ fullName = excellents.ElementAt(1).firstName + " " + excellents.ElementAt(1).lastName, marks = excellents.ElementAt(1).marks},
            //                        new{ fullName = excellents.ElementAt(2).firstName + " " + excellents.ElementAt(2).lastName, marks = excellents.ElementAt(2).marks}};
            
            //foreach (var item in newAnonimus)
            //{
            //    Console.WriteLine("{0} {1}", item.fullName, item.marks.showList());
            //}

            ////14.
            //var excellents =
            //    from studs in Students.All
            //    where studs.marks.Count(i => i < 3) >= 2
            //    select studs;

            ////var newAnonimus = excelents.ToList()[0];
            //var newAnonimus = new[] {new{ fullName = excellents.ElementAt(0).firstName + " " + excellents.ElementAt(0).lastName, marks = excellents.ElementAt(0).marks},
            //                        new{ fullName = excellents.ElementAt(1).firstName + " " + excellents.ElementAt(1).lastName, marks = excellents.ElementAt(1).marks}};

            //foreach (var item in newAnonimus)
            //{
            //    Console.WriteLine("{0} {1}", item.fullName, item.marks.showList());
            //}

            ////16.
            //Group secound = new Group(2, "Mathematics");
            //Group poohBear = new Group(3, "Honey collecting");
            //Group engineers = new Group(1, "Informatics");

            //var separatedbyGroup =
            //    from studyGroup in Group.groupAll
            //    join studs in Students.All on studyGroup.GroupNumber equals studs.groups into grouped
            //    select new { DepName = studyGroup.DepartmentName, Students = grouped };

            //foreach (var currentGroup in separatedbyGroup)
            //{
            //    Console.WriteLine(currentGroup.DepName);
            //    foreach (var stude in currentGroup.Students)
            //    {
            //        Console.WriteLine("   {0} {1}", stude.firstName, stude.lastName);
            //    }
            //}

            ////18.
            //Group engineers = new Group(1, "Informatics");
            //Group secound = new Group(2, "Mathematics");
            //Group poohBear = new Group(3, "Honey collecting");
            //Group justtoHave = new Group(4, "Wood planting");

            //var separatedbyGroup =
            //    from stgroup in Group.groupAll
            //    join studs in Students.All on stgroup.GroupNumber equals studs.groups into combinedStudents
            //    select new { DepName = stgroup.DepartmentName, GroupNum = stgroup.GroupNumber, Students = combinedStudents };

            //foreach (var item in separatedbyGroup)
            //{
            //    Console.WriteLine("Group {0} Students", item.GroupNum);
            //    foreach (var stud in item.Students)
            //    {
            //        Console.WriteLine("   {0} {1} {2}", stud.firstName, stud.lastName, stud.groups);
            //    }
            //}

            //19.
            Group engineers = new Group(1, "Informatics");
            Group secound = new Group(2, "Mathematics");
            Group poohBear = new Group(3, "Honey collecting");
            Group justtoHave = new Group(4, "Wood planting");

            List<string> combinedGroups = new List<string>();
            combinedGroups = combinedGroups.joinQuary();

            foreach (var item in combinedGroups)
            {
                Console.WriteLine(item);
            }
        }
    }
}
