using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09.Arithmetical_expressions
{
    class Program
    {
        public static string TrimInput(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }

        public static List<char> arithmeticOperations = new List<char>() { '+', '-', '*', '/' };
        public static List<char> brakets = new List<char>() { '(', ')' };
        public static List<string> functions = new List<string>() {"ln", "pow", "sqrt"};
        public static List<string> SeparateTokens(string input)
        {
            var result = new List<string>();

            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (i == 0 || input[i-1] == ',' || input[i-1] == '('))
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                else if (brakets.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (arithmeticOperations.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 2 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 3 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i+=2;
                }
                else if (i + 4 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
            }
            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }
            return result;
        }
        public static int Precendence(string aritmeticOperator)
        {
            if (aritmeticOperator == "+" || aritmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static void PutInvariantCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }
        public static Queue<string> ConvertToRevers(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;

                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(currentToken);
                }
                else if(functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid Brackets or function separator");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (arithmeticOperations.Contains(currentToken[0]))
                {
                    //if not working refactor logic fo current token
                    while (stack.Count != 0 && arithmeticOperations.Contains(stack.Peek()[0]) && Precendence(currentToken) <= Precendence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(currentToken);
                }
                else if (currentToken == "(")
                {
                    stack.Push("(");
                }
                else if (currentToken == ")")
                {
                    if (!stack.Contains("("))
                    {
                        throw new ArgumentException("Invalid brackets");
                    }
                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Pop();
                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }
            while (stack.Count != 0)
            {
                if (brakets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid brackets");
                }
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        public static double GetResultFromRPN(Queue<string>queue)
        {
            Stack<double> stack = new Stack<double>();

            while (queue.Count != 0)
            {
                string currentToken = queue.Dequeue();
                double number;
                if (double.TryParse(currentToken, out number))
                {
                    stack.Push(number);
                }
                else if (arithmeticOperations.Contains(currentToken[0]) || functions.Contains(currentToken))
                {
                    if (currentToken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secoundValue = stack.Pop();

                        stack.Push(secoundValue + firstValue);
                    }
                    else if (currentToken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secoundValue = stack.Pop();

                        stack.Push(secoundValue - firstValue);
                    }
                    else if (currentToken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secoundValue = stack.Pop();

                        stack.Push(secoundValue * firstValue);
                    }
                    else if (currentToken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secoundValue = stack.Pop();

                        stack.Push(secoundValue / firstValue);
                    }
                    else if (currentToken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double firstValue = stack.Pop();
                        double secoundValue = stack.Pop();

                        stack.Push(Math.Pow(secoundValue,firstValue));
                    }
                    else if (currentToken == "sqrt")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentToken == "ln")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }
                        double value = stack.Pop();

                        stack.Push(Math.Log(value));
                    }
                }
            }
            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }
        static void Main()
        {
            PutInvariantCulture();
            string text = "3 - 2";//Console.ReadLine();//"pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
            //"pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)"
            //"(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
            //"1 + 2".Trim();
            //"3 + 4 * 2/(1-5)";
            //Console.WriteLine(TrimInput(text));

            //Usefull videos for this program
            //https://vimeo.com/channels/100479/10941784
            //Telerik video
            //https://www.youtube.com/watch?v=a6wOX5zjyIQ
            //https://www.youtube.com/watch?v=Flyvw7tmEBg

            while (text.ToLower() != "end")
            {
                try
                {
                    var separatedTokens = SeparateTokens(TrimInput(text));

                    var reversePolish = ConvertToRevers(separatedTokens);

                    var finalResult = GetResultFromRPN(reversePolish);
                    Console.WriteLine(finalResult);
                }
                catch (ArgumentException greshka)
                {
                    Console.WriteLine(greshka.Message);
                }
            }
        }
    }
}
