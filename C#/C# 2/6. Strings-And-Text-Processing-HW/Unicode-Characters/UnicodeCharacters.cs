/*  10. Unicode characters
    Write a program that converts a string to a sequence of C# Unicode character literals.
    Input: On the only input line you will receive a string
    Output: Print the string in C# Unicode character literals on a single line
    Sample tests:
                    Input 	    Output
                    Hi! 	    \u0048\u0069\u0021
 */

// 60/100 in bgcoder

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder answer = new StringBuilder();
        
        for (int i = 0; i < input.Length; i++)
        {
            answer.AppendFormat("\\u{0:X4}", (int)input[i]);
            //answer.Append(string.Format("\\u{0:X4}", (int)input[i]));
        }

        // other way
        //foreach (char character in input)
        //{
        //    answer.AppendFormat("\\u{0:X4}", (int)character);
        //}

        Console.WriteLine(answer.ToString());
    }
}