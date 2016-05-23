/*  8. Extract sentences
    Write a program that extracts from a given text all sentences containing given word.
    Input: 
            On the first line you will receive a string - the word
            On the second line you will receive a string - the text
    Output: Print only the sentences containing the word on a single line
    Constraints: Sentences are separated by . and the words – by non-letter symbols
    Sample tests:
    Input: 	
    in
    We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    Output:
    We are living in a yellow submarine. We will move out of it in 5 days.
 */

// 90/100 in bgcoder

using System;
using System.Linq; // needed for Where()

class ExtractSentences
{
    static void Main()
    {
        string wordSearch = Console.ReadLine().Trim().ToLower();
        string text = Console.ReadLine();

        string[] sentences = text
            .Split(new string[] { ".", "!", "?", "..." }, StringSplitOptions.RemoveEmptyEntries);
        char[] separators = GetNonLetterSymbols(text);

        foreach (string sentence in sentences)
        {
            string[] words = sentence
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (word.Trim().ToLower() == wordSearch)
                {
                    Console.Write(sentence + ".");
                    break;
                }
            }
        }

    }

    private static char[] GetNonLetterSymbols(string input)
    {
        char[] symbols = input
            .Where(ch => !char.IsLetter(ch)) // needs System.Linq
            .Distinct() // removes all duplicate elements in a collection; returns only the distinct elements
            .ToArray();

        return symbols;
    }
}