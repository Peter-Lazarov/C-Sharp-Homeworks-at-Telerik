using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lectures
{
    class lectures
    {
        static void Main()
        {
            //Prime or composite number
            //uint number = Convert.ToUInt32(Console.ReadLine());
            //uint divider = 2;
            //uint maxDivider = (uint)Math.Sqrt(number);
            //bool isPrime = true;

            //while (isPrime && divider <= maxDivider)
            //{
            //    if (number % divider == 0)
            //    {
            //        isPrime = false;
            //        Console.WriteLine("No, the number {0} is composite", number);
            //        return;
            //    }
            //    divider++;
            //}
            //Console.WriteLine("Yes, the number {0} is prime", number);

            // Sum example
            //int number = 1;
            //int sum = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Sum = ");
            //do
            //{
            //    if(number == n)
            //    {
            //        Console.Write(number);
            //    }
            //    else
            //    {
            //        Console.Write(number + " + ");
            //    }
            //    sum = number + 1;
            //    number = number + 1;
            //}while(number <= n);

            //Console.WriteLine(" = " + sum);

            //Factorial
            //int n = Convert.ToInt32(Console.ReadLine());
            ////decimal factorial = 1;
            ////must add using System.Numerics;
            //BigInteger factorial = 1;

            //do
            //{
            //    factorial = factorial * n;
            //    n = n - 1;
            //}while(n > 1);
            //Console.WriteLine("n! = " + factorial);

            //For loops
            //for (int number = 0; number <= 10; number ++)
            //{
            //    Console.WriteLine(number);
            //}

            ////For loops - complex
            //for (int i = 1, sum = 1; i <= 128; i=i*2, sum=sum + i )
            //{
            //    Console.WriteLine("i={0}, sum={1}", i, sum);
            //}

            //// For loop for odd numbers
            //int n = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i=1; i<=n;i = i + 2)
            //{
            //    if(i%7==0)
            //    {
            //        continue;
            //    }
            //    sum = sum + i;
            //}
            //Console.WriteLine("Sum is {0}",sum);

            //List<int> arr = new List<int>() { 1, 3, 5, 7, 9 };
            //Console.WriteLine(arr[3]);
            //arr.Insert(3, 20);
            //Console.WriteLine(arr[3]);

            ////Array count - Lenght
            //string[] arr = new string[] {"Pesho", "Gosho", "Tosho"};
            //Console.WriteLine(arr.Length);

            ////Days of week
            //string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", 
            //                    "Friday", "Saturday", "Sunday" };
            //foreach(string day in days)
            //{
            //    Console.WriteLine(day);
            //}

            ////Fill up list - Mogo iako
            //string linia = Console.ReadLine();
            //List<string> spisak = new List<string>();

            //while (linia != "end")
            //{
            //    spisak.Add(linia);

            //    linia = Console.ReadLine();
            //}

            //foreach(var element in spisak)
            //{
            //    Console.WriteLine(element);
            //}

            ////String to array
            //string str = "Hello C Sharp!";
            ////1
            //Console.WriteLine(str[1]);
            
            ////2
            //foreach(var element in str)
            //{
            //    Console.WriteLine(element);
            //}

            //Console.WriteLine();
            //char[] arr = str.ToCharArray();

            //arr[0] = 'h';
            //foreach (var element in arr)
            //{
            //    Console.WriteLine(element);
            //}

            ////Nested loops
            //int counter = 0;
            //for (int i = 0; i < 5;i++)
            //{
            //    for (int j = 0; j < 5;j++)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);

            ////2
            //int counter = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        for (int k = 0; k < 5; k++)
            //        {
            //            for (int l = 0; l < 5; l++)
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(counter);

        }
    }
}
