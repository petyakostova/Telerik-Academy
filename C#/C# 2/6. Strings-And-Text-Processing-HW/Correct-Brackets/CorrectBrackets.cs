/*  3. Correct brackets
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
                    Console.WriteLine("Incorrect");
                    return;
                }
            }
        }

        if (counter != 0)
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