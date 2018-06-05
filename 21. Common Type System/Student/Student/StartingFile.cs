using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    using Classes;
    class StartingFile
    {
        static void Main()
        {
            Student Pesho = new Student("Pesho", "Goshov", "Todorov", "092511", "Vratza", "0888123456", "samone@abv.bg", Specialty.Geodesy, University.MGU, Faculty.Mechanical);

            Student Ivan = new Student("Ivan", "Goshov", "Todorov", "092511", "Vratza", "0888123456", "samone@abv.bg", Specialty.Geodesy, University.MGU, Faculty.Mechanical);

            bool traing = Pesho == Ivan;
            Console.WriteLine(traing);
            Console.WriteLine(Pesho.ToString());

            //Problem 2 - Clone
            Student newbie = (Student)Pesho.Clone();
            Console.WriteLine(newbie.ToString());
            Console.WriteLine();

            Pesho.Speciality = Specialty.Automation;
            Pesho.University = University.TU;

            Console.WriteLine(Pesho.ToString());
            Console.WriteLine(newbie.ToString());

            //Problem 3 - Compare
            Console.WriteLine();
            Console.WriteLine("Problem 3 - Compare to");
            Console.WriteLine(Pesho.CompareTo(Ivan));

            //Problem 4 - Person
            Console.WriteLine();
            Person mrPesho = new Person("Peshoto", 31);
            Person mrGosho = new Person("Gosheto");
            Console.WriteLine(mrPesho.ToString());
            Console.WriteLine(mrGosho.ToString());
        }
    }
}
