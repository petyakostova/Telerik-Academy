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

using System;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string sentence in sentences)
        {
            //string checkingSentence = sentence;

            int index = sentence.IndexOf(word);

            if (index > -1)
            {
                if (index + word.Length <= sentence.Length - 1)
                {
                    if (Char.IsLetter(sentence[index + word.Length]))
                    {
                        continue;
                    }
                }

                Console.Write(sentence + ".");
            }
        }

    }
}