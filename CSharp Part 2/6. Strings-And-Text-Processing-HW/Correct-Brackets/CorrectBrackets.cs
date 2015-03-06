/*  Problem 3. Correct brackets
    Write a program to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d). 
    Example of incorrect expression: )(a+b)).
 */

using System;

class CorrectBrackets
{
    static void Main()
    {
        /* Use counting of the brackets: 
         * For an opening bracket increase the counter by 1 and for closing bracket decrease it by 1. 
         * Watch the counter not to become a negative number and always ends with 0.
         */
        string expression = Console.ReadLine();

        bool correctBrackets = true;

        int counter = 0;

        for (int index = 0; index < expression.Length; index++)
        {
            char ch = expression[index];

            if (ch == '(')
            {
                counter++;
            }
            else if (ch == ')')
            {
                counter--;
                if (counter < 0)
                {
                    correctBrackets = false;
                    break;
                }
            }
        }

        if (counter != 0)
        {
            correctBrackets = false;
        }

        Console.WriteLine("Are the brackets correct?\n" + correctBrackets);
        
    }
}