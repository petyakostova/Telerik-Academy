/*  Problem 20. Palindromes
    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */

using System;
using System.Text;


class Palindromes
{
    static void Main()
    {
        //// the real input
        //string text = Console.ReadLine();
        // the input for faster testing        
        string text = "Lamal? Every time I see a palindrome, I listen ABBA and feel like running an exe (lamal).";
       
        var sb = new StringBuilder();

        foreach (char ch in text)
        {
            if (char.IsPunctuation(ch))
            {
                sb.Append(ch);
            }                
        }
        sb.Append((char)32);    // adding spaces

        string punctuation = sb.ToString();       

        string[] words = text.Split(punctuation.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Palindromes: ");
        foreach (string word in words)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                // Lamal, lamaL are palindromes. => case insensitive
                if (word[i] != word[word.Length - 1 - i] && word[i] != (char)(word[word.Length - 1 - i] - 32))
                //if (word[i] != word[word.Length - 1 - i])   // Lamal, lamaL are not palindromes. => case sensitive
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)    // don't need 1 letter words
            {
                Console.WriteLine(word);
            }
        }

    }
}