using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    class lecture
    {
        static void Main()
        {
            ////every letter from sentence
            //string s = "Stand up, stand up, Balkan Superman.";
            //Console.WriteLine("s = {0}", s);
            //Console.WriteLine("s = \"{0}\"", s);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine("s[{0}] = {1}", i, s[i]);
            //}

            ////Are one of strings are in the oher
            //Console.WriteLine("abcd".CompareTo("abcdefg"));// 1 strA follows strB in the sort order.
            //Console.WriteLine("abcd".CompareTo("abcd"));//0 strA occurs in the same position as strB in the sort order.
            //Console.WriteLine("abcddksjfksjdl".CompareTo("abcdf"));// -1 strA precedes strB in the sort order.

            //int result = string.Compare("abc", "ABC", false);
            //Console.WriteLine(result);

            //string[] towns = { "Sofia", "Varna", "Plovdiv", "Pleven",
            //                     "Bourgas", "Rousse", "Yambol"};
            //string firstTown = towns[0];
            //for (int i = 1; i < towns.Length; i++)
            //{
            //    string currentTown = towns[i];
            //    if (string.Compare(currentTown, firstTown) < 0)
            //    {
            //        firstTown = currentTown;
            //    }
            //}
            //Console.WriteLine("First town: {0}", firstTown);

            //string text = "1,2 3,4,5 6";
            //string[] numberAsText = text.Split(',', ' ');


            ////Multiple spaces input (or character)
            //string text = "1     2,3 4!5,,,,6";

            //string[] numbertext = text.Split(new char[] {' ', ',', '!'}, StringSplitOptions.RemoveEmptyEntries);
            //int[] numbers = new int[numbertext.Length];

            //for (int i = 0; i < numbertext.Length; i++)
            //{
            //    numbers[i] = int.Parse(numbertext[i]);
            //}
            //Console.WriteLine(String.Join(" ", numbers));

            //string text = "Pesho";
            ////text = text.Remove(0, 2);
            //text = text.Remove(1);
            //Console.WriteLine(text);

            //string text = "Pesho";
            //text = text.ToLower();
            //Console.WriteLine(text);
            //text = text.ToUpper();
            //Console.WriteLine(text);

            //string text = "               Pesho         ";
            //text = text.Trim();
            ////text = text.TrimStart();
            ////text = text.TrimEnd();
            //Console.WriteLine(text + "A");

            //string text = "aaaaaaaccccc               Peshaaaao         aaaaaabbbbb";
            //text = text.Trim('a');
            //text = text.Trim('a', 'b', 'c');
            ////text = text.TrimStart();
            ////text = text.TrimEnd();
            //Console.WriteLine(text + "b");

            //Adding string
            //string text = string.Empty;

            //for (int i = 0; i < 100000; i++)
            //{
            //    text += "a";
            //}

            //Console.WriteLine(text);

            ////Adding string with string builder
            //StringBuilder result = new StringBuilder();

            //for (int i = 0; i < 10000; i++)
            //{
            //    result.Append("a");
            //    result.AppendLine("a");
            //}
            //string text = result.ToString();// leave empty row
            //Console.WriteLine(text);
            //text = result.ToString().Trim();// not leave empty row
            //Console.WriteLine(text);

            //// String reverse
            //string text = "Pesho";
            //StringBuilder result = new StringBuilder(text.Length);
            //string reversed = "";

            //for (int i = text.Length - 1; 0 <= i ;  i--)
            //{
            //    result.Append(text[i]);
            //}
            //reversed = result.ToString();
            //Console.WriteLine(reversed);

            ////Extract capital letters
            //string text = "Vratza City";
            //var result = new StringBuilder(text.Length);
            //string capital = "";

            //for (int i = 0; i <text.Length; i++)
            //{
            //    if (text[i] >= 'A' && text[i] <= 'Z')
            //    {
            //        result.Append(text[i]);
            //    }
            //}

            //capital = result.ToString();
            //Console.WriteLine(capital);

            //String Formats
            //int number = 42;
            //string text = number.ToString("c"); // curency
            //Console.WriteLine(text);

            ////String Formats
            //string text = string.Format("{0:F2}", 45);
            //Console.WriteLine(text);

            ////Using string with template
            //string template = "If I ware {0}, I would {1}.";
            //string sentence1 = String.Format(template, "developer", "know C#");
            //Console.WriteLine(sentence1);

            //string sentence2 = String.Format(template, "elephant", "weigh 4500 kg");
            //Console.WriteLine(sentence2);

            ////Adding spaces - composite formating
            ////{index[,aligment][:formatString]}
            //double d = 0.375;
            //string s = string.Format("{0,10:F5}", d);
            //Console.WriteLine(s);
            ////"   0,37500"

            //int number = 42;
            //Console.WriteLine("Dec {0:D} = Hex {1:X}", number, number);
            ////Dec 42 = Hex 2A

            ////Date formating
            //DateTime sega = DateTime.Now;
            //Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}", sega);
            //Console.WriteLine("Now is {0:dd.MMMM.yyyy HH:mm:ss}", sega);
            //Console.WriteLine("{0:yyyy - d,MM}", sega);
        }
    }
}
