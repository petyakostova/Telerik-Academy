/*  Problem 12. Index of letters
    Write a program that creates an array containing all letters from the alphabet (A-Z).
    Read a word from the console and print the index of each of its letters in the array.
 */

using System;

class IndexOfLetters
{
    static void Main()
    {
        int[] lettersArray = new int[26];

        // creating an array containing all letters from the alphabet (A-Z)
        for (int i = 0, next = 0; i < 26; i++, next++)
        {
            lettersArray[i] = 'A' + next;
        }

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        // printing the index of each of word's letters in the array 
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < lettersArray.Length; j++)
            {
                if (word[i] == lettersArray[j])
                {
                    Console.WriteLine("Letter {0} has index: {1}", word[i], j);
                    break;
                }
            }
        }

    }
}