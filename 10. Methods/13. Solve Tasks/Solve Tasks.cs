using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Solve_Tasks
{
    class Program
    {
        static void Reverse(string digits)
        {
            while (digits[0] == '-')
            {
                Console.WriteLine("Negative decimal numbers not allowed. Try again");
                digits = Console.ReadLine();
            }
            int n = digits.Length;
            char[] all = new char[n];
            all = digits.ToCharArray();
            char[] rev = new char[n];

            for (int i = 0; i < n / 2 + 1; i++)
            {
                rev[n - i - 1] = all[i];
                rev[i] = all[n - i - 1];
            }
            foreach (var item in rev)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Average(string sequence)
        {
            while (sequence == "")
            {
                Console.WriteLine("You must enter some numbers");
                sequence = Console.ReadLine();
            }
            int[] all = sequence.Split(' ').Select(int.Parse).ToArray();
            float average = 0;
            for (int i = 0; i < all.Length; i++)
            {
                average += all[i]; 
            }
            average /= all.Length;
            Console.WriteLine(average);
        }
        static void Equation(string ab)
        {
            //a * x + b = 0
            int[] all = ab.Split(' ').Select(int.Parse).ToArray();
            while (all[0] == 0)
            {
                Console.WriteLine("a parameter must not be zero");
                ab = Console.ReadLine();
                all = ab.Split(' ').Select(int.Parse).ToArray();
            }
            float x = 0;
            x = -all[1] / all[0];
            Console.WriteLine(x);
        }
        static void Main()
        {
            Console.WriteLine("Please choose an option for task.");
            Console.WriteLine("(R)everses a number, (A)verage of a sequence, (E)quation a * x + b = 0");
            
            char choise = Convert.ToChar(Console.ReadLine());
            switch (choise)
            {
                case 'r':
                    Console.WriteLine("Enter a number to be reversed");
                    Reverse(Console.ReadLine());
                    break;
                case 'a':
                    Console.WriteLine("Enter a sequence of integers separated by space character.");
                    Average(Console.ReadLine());
                    break;
                case 'e':
                    Console.WriteLine("Enter a and b parameters separated by space character.");
                    Equation(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
