/*  23. Series of letters
    Write a program that reads a string from the console and 
    replaces all series of consecutive identical letters with a single one.
    Input: On the only input line you will receive a string
    Output: Print the string without consecutive identical letters
    Sample tests: 
                        Input 	                    Output
                        aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */

using System;
using System.Text;  // needed for StringBuilder

class SeriesOfLetters
{
    static void Main()
    {
        string str = Console.ReadLine();       

        StringBuilder answer = new StringBuilder();

        answer.Append(str[0]);

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != str[i - 1])
            {
                answer.Append(str[i]);
            }
        }

        Console.WriteLine(answer.ToString());
    }
}