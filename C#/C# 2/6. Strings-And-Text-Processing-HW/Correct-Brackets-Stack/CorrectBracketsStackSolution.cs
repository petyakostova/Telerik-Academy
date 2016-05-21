/*  3. Correct brackets - Solution with Stack data structure
    Write a program to check if in a given expression the ( and ) brackets are put correctly.
    Input: On the only line you will receive an expression
    Output: Print Correct if the brackets are correct. Incorrect otherwise
    Constraints: 1 <= length of expression <= 10000
    Sample tests:
                    Input 	        Output
                    ((a+b)/5-d) 	Correct
                    )(a+b)) 	    Incorrect
 */

using System;
using System.Collections.Generic;

class CorrectBracketsStackSolution
{
    static void Main()
    {
        string expression = Console.ReadLine();

        Stack<int> stack = new Stack<int>();    // need using System.Collections.Generic;
        /* The stack is a data structure, which implements the behavior "last in – first out" (LIFO). 
           The elements could be added and removed only on the top of the stack. */

        bool correctBrackets = true;

        for (int index = 0; index < expression.Length; index++)
        {
            char ch = expression[index];

            if (ch == '(')
            {
                stack.Push(index);  // adds a new element on the top of the stack
            }
            else if (ch == ')')
            {
                if (stack.Count == 0)   // returns the count of elements in the stack
                {
                    correctBrackets = false;
                    Console.WriteLine("Incorrect");
                    return;
                }
                stack.Pop();    // returns the highest element and removes it from the stack
            }
        }

        if (stack.Count != 0)
        {
            correctBrackets = false;
            Console.WriteLine("Incorrect");
        }

        if (correctBrackets)
        {
            Console.WriteLine("Correct");
        }
    }
}