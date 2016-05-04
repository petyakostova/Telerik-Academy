/*  Problem 12. Index of letters
    Write a program that creates an array containing all letters from the alphabet (a-z). 
    Read a word from the console and print the index of each of its letters in the array.
    Input: On the first line you will receive the word
    Output: Print the index of each of the word's letters in the array. Each index should be on a new line.
    Constraints: 1 <= word length <= 128. Word is consisted of lowercase english letters.  */

using System;

class IndexOfLetters
{
    static void Main()
    {
        // input
        string word = Console.ReadLine();

        int[] lettersArray = new int[26];
        // creating an array containing all letters from the alphabet (a-z)
        for (int i = 0; i < 26; i++)
        {
            lettersArray[i] = 'a' + i;
        }
        
        // printing the index of each of word's letters in the array 
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < lettersArray.Length; j++)
            {
                if (word[i] == lettersArray[j])
                {
                    Console.WriteLine(j);
                    break;
                }
            }
        }

    }
}