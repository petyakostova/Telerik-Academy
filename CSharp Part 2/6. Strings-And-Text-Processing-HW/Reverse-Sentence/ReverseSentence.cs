/*  Problem 13. Reverse sentence
    Write a program that reverses the words in given sentence.
    Example:
    input 	                                    output
    C# is not C++, not PHP and not Delphi! 	    Delphi not and PHP, not C++ not is C#!
 */

using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!"; // input for faster testing
        //string sentence = Console.ReadLine();   // the real input

        var revercedSentence = new StringBuilder(sentence.Length);

        char lastSign = sentence[sentence.Length - 1];

        string[] allWords = sentence.Substring(0, sentence.Length - 1).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(allWords);

        Console.WriteLine("Reversed: {0}{1}\n", string.Join(" ", allWords), lastSign);  // Delphi not and PHP not C++, not is C#!

    }
}