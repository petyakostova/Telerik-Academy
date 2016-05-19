/*  9. Arithmetical expressions
    Write a program that calculates the value of given arithmetical expression.
    The expression can contain the following elements only:
    Real numbers, e.g. 5, 18.33, 3.14159, 12.6
    Arithmetic operators: +, -, *, / (standard priorities)
    Mathematical functions: ln(x), sqrt(x), pow(x,y)
    Brackets (for changing the default priorities): (, )
    Input: On the only line you will receive an expression
    Output: Print the result of the expression
    Constraints: The size of the expression will not be more than 10000 symbols.
    Sample tests: 
                    Input 	                                                Output
                    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) 	            ~10.6
                    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) 	    ~21.22
    Hint: Use the classical Shunting-yard algorithm and Reverse Polish notation. */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class MathExpressions
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine().Trim().Replace(" ", string.Empty);
        var tokens = ExtractTokens(input); //getting all of the tokens from the initial input
        var reversedPolishNotation = ConvertToRPN(tokens); //converting tokens to RPN using Shunting-yard algorithm
        Console.WriteLine(CalculateRPN(reversedPolishNotation)); //calculating the result using the algorithm for RPN
    }

    public static List<char> specialChars = new List<char>() { '+', '-', '/', '*', '(', ')', ',' };
    public static List<string> functions = new List<string>() { "ln", "pow", "sqrt" };
    public static List<string> operators = new List<string>() { "+", "-", "*", "/" };

    public static int Precedence(string command)
    {
        if (command == "+" || command == "-")
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }

    static List<string> ExtractTokens(string input)
    {
        List<string> result = new List<string>();
        var number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
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
            else if (specialChars.Contains(input[i]))
            {
                result.Add(input[i].ToString());
            }
            else if (i < input.Length - 1 && input.Substring(i, 2).ToLower() == "ln")
            {
                result.Add("ln");
                i++;
            }
            else if (i < input.Length - 2 && input.Substring(i, 3).ToLower() == "pow")
            {
                result.Add("pow");
                i += 2;
            }
            else if (i < input.Length - 3 && input.Substring(i, 4).ToLower() == "sqrt")
            {
                result.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }
        }

        if (number.Length != 0)
        {
            result.Add(number.ToString());
        }

        return result;
    }

    public static Queue<string> ConvertToRPN(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            var currentToken = tokens[i];
            double currentNumber;

            if (double.TryParse(currentToken, out currentNumber))
            {
                queue.Enqueue(currentToken);
            }
            else if (functions.Contains(currentToken))
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ",")
            {
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid expression!");
                }
                while (stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (operators.Contains(currentToken))
            {
                while (stack.Count != 0 && operators.Contains(stack.Peek()) && Precedence(currentToken) <= Precedence(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
                stack.Push(currentToken);
            }
            else if (currentToken == "(")
            {
                stack.Push(currentToken);
            }
            else if (currentToken == ")")
            {
                if (!stack.Contains("("))
                {
                    throw new ArgumentException("Invalid expression!");
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
        while (stack.Count > 0)
        {
            if (stack.Peek() == "(" || stack.Peek() == ")")
            {
                throw new ArgumentException("Invalid expression!");
            }
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

    public static double CalculateRPN(Queue<string> queue)
    {
        Stack<double> stack = new Stack<double>();
        double finalResult;

        while (queue.Count != 0)
        {
            double number;
            string currentToken = queue.Dequeue();
            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else
            {
                if (currentToken == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        double result = firstNumber + secondNumber;

                        stack.Push(result);
                    }
                }
                else if (currentToken == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        double result = secondNumber - firstNumber;

                        stack.Push(result);
                    }
                }
                else if (currentToken == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        double result = secondNumber * firstNumber;

                        stack.Push(result);
                    }
                }
                else if (currentToken == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        double result = secondNumber / firstNumber;

                        stack.Push(result);
                    }
                }
                else if (currentToken == "pow")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double firstNumber = stack.Pop();
                        double secondNumber = stack.Pop();
                        double result = Math.Pow(secondNumber, firstNumber);

                        stack.Push(result);
                    }
                }
                else if (currentToken == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double currentNumber = stack.Pop();
                        double result = Math.Sqrt(currentNumber);

                        stack.Push(result);
                    }
                }
                else if (currentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Not enough numbers in the stack");
                    }
                    else
                    {
                        double currentNumber = stack.Pop();
                        double result = Math.Log(currentNumber);

                        stack.Push(result);
                    }
                }
            }

        }
        if (stack.Count == 1)
        {
            finalResult = stack.Pop();
        }
        else
        {
            throw new ArgumentException("Invalid Expression");
        }

        return finalResult;
    }
}