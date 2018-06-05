using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    public class lecture
    {
        //to Delegates part
        public delegate void FirstDelegate(string input, int count);

        public delegate int GenericDelegate<T>(T input);

        public static void MethodToDelegate(string text, int number)
        {
            Console.WriteLine("Delegate call" + " " + text + " " + number);
        }

        public static int AnotherMethod(string number)
        {
            Console.WriteLine("Special Method 1");
            return 42;
        }

        public static int AnotherMethod2(string number)
        {
            Console.WriteLine("Special Method 2");
            return 24;
        }
        //to Delegates part end

        public static void Main()
        {
            //Extension Methods
            var text = "Pesho Ivanov Todorov";
            Console.WriteLine(text.CountWords());

            //secound example
            List<int> number = new List<int>();
            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.IncreaseWithNumber(5);

            //Extension Method end

            //Anonymous Type
            var student = new Student { FirstName = "Pesho", LastName = "Goshtov" };

            var studentAno = new { FirstName = "Ivan", LastName = "Todorov" };
            Console.WriteLine(studentAno.FirstName); ;

            var nums = new[] { 1, 2, 3 }; //Anonymos Type Array
            //Anonymous Type end

            ////Delegates
            //var myDelegate = new FirstDelegate(MethodToDelegate);
            //myDelegate("Pesho", 15);

            ////Generic delegate
            //GenericDelegate<string> generidelegate = int.Parse;
            //generidelegate += AnotherMethod;
            //generidelegate += AnotherMethod2;
            //generidelegate -= AnotherMethod2;

            //Console.WriteLine(generidelegate("2"));
            ////Delegates end

            ////Anonymos Method
            //generidelegate += delegate(string input)
            //{
            //    Console.WriteLine("Anonymos Method " + input);
            //    return 0;
            //};
            //Console.WriteLine(generidelegate("200"));
            ////Anonymos Method end

            ////Action
            //Action<string, int> myAction = MethodToDelegate;
            //myAction("ActionProba", 20);
            //PrintMethod(myAction);

            //Action<string> cwa = Console.WriteLine;

            //Func<int> myFunc = ReturnAnswerToEverthing;

            ////Lambda
            //////---------------------------------------------------
            //Func<string, int> lambda = text => 42;
            //int result = lambda("5");

            //Func<string, int> lambda2 = text =>
            //{
            //    return 42;
            //};

            //var list = new List<int> { 4, 3, 0, 1243 };
            //var sortedList = list.OrderBy(x => x).ToList();


            ////ex 1
            //List<int> digits = new List<int>() {1, 2, 3, 4 };
            //List<int> evenNumbers = digits.FindAll(x => (x % 2) == 0);
            //foreach (var digit in digits)
            //{
            //    Console.Write("{0} ", digit);
            //}
            //Console.WriteLine();
            //digits.RemoveAll(x => x > 3);

            ////ex 2
            //var pets = new[]
            //{
            //    new {Name="Sharo", Age=8},
            //    new {Name="Rex", Age=4},
            //    new {Name="Strela", Age=1},
            //    new {Name="Bora", Age=3}
            //};

            //var sortdPets = pets.OrderBy(p => p.Age);

            ////ex 3
            //Action<int> lambdaAction = x => Console.WriteLine(x);
            //lambdaAction(5);

            ////Predicate
            ////---------------------------------------------------
            //var numbers = new List<int> { 1, 2, 3, 4 };
            //var filtered = numbers.Where(n => n > 2);

            ////LINQ
            ////---------------------------------------------------
            //var numbers = new List<int> { 1, 2, 6, 3, 8, 10 };
            //var lessThanFive =
            //    from n in numbers
            //    where n < 5
            //    select n;

            ////ex 2
            //var text = "Hi, I am C Sharp C Sharp C Sharp";
            //var search = "sharp";

            //var result = text
            //    .Split(' ')
            //    .Where(w => w.ToLower() == search.ToLower())
            //    .Count();
            //Console.WriteLine(result);

            ////ex 3
            //var text = "Hi, I am C Sharp C Sharp C Sharp";

            //var result = text.Where(s => s == 'c' || s == 'C').Count();
            //Console.WriteLine(result);

            //2:22:00
            ////Event
            ////---------------------------------------------------
            //// Create a new list.
            //ListWithChangedEvent list = new ListWithChangedEvent();

            //// Add and remove items from the list.
            //Console.WriteLine("----- Adding item 1");
            //list.Add("item 1");
            //list.Clear();

            //// Attach method as a listener
            //// list.Changed += new ChangedEventHandler(ListOnChanged);
            //list.Changed += ListOnChanged;

            //// Attach delegate as a listener
            //list.Changed += delegate(object sender, EventArgs args)
            //{
            //    Console.WriteLine("degate(object sender, EventArgs args)");
            //};

            //// Attach anonymous type as a listener
            //list.Changed += (sender, args) => Console.WriteLine("(sender, args) =>");

            //Console.WriteLine("----- Adding item 2");
            //list.Add("item 2");

            //list.Changed -= ListOnChanged;

            //Console.WriteLine("----- Adding item 3");
            //list.Add("item 3");


        }
        ////Event
        //private static void ListOnChanged(object sender, EventArgs eventArgs)
        //{
        //    Console.WriteLine("ListOnChanged(object sender, EventArgs eventArgs)");
        //}

        //Func
        public static int ReturnAnswerToEverthing()
        {
            return 42;
        }

        //Action
        public static void PrintMethod(Action<string, int> action)
        {
            action("15", 10);
        }
    }
}
