/*  Problem 8. Extract sentences
    Write a program that extracts from a given text all sentences containing given word.
    Example:
        The word is: "in"
        The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
        The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
    Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

using System;

class ExtractSentences
{
    static void Main()
    {
        // input for faster testing
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        
        //// the real input
        //Console.WriteLine("Enter a text:");
        //string text = Console.ReadLine();
        //Console.WriteLine("Enter a word:");
        //string word = Console.ReadLine();

        string[] sentences = text.Split(new char[]{'.'}, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            string checkingSentence = sentence.ToLower();
            int index = checkingSentence.IndexOf(word.ToLower() + " ");

            if (index > -1)
            {
                Console.Write(sentence.Trim() + ". ");
            }
        }

        Console.WriteLine();
    }
}