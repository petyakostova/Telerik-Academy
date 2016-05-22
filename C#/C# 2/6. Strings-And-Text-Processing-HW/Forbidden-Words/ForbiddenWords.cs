/*  9. Forbidden words
    We are given a string containing a list of forbidden words and a text containing some of these words. 
    Write a program that replaces the forbidden words with asterisks.
    Sample tests:
    Input: 	
    Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
    PHP CLR Microsoft
    Output:
    ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 */

using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] forbiddenWords = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder asterisksReplacedText = new StringBuilder();

        asterisksReplacedText.Append(text);

        foreach (string word in forbiddenWords)
        {
            // replace word with new string('*', word.Length)
            asterisksReplacedText.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(asterisksReplacedText);
    }
}