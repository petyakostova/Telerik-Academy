/*  Problem 21. Letters count
    Write a program that reads a string from the console and 
    prints all different letters in the string along with information how many times each letter is found.
 */

using System;
using System.Collections.Generic;   // needed for Dictionary
using System.Linq;  // needed for OrderBy and OrderByDescending

class LettersCount
{
    static void Main()
    {
        //// the real input
        //string str = Console.ReadLine();
        // input for faster testing
        string str = "aaa bbb BBBB AAAAA bbb 0123456";

        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            // void Dictionary<char,int>.Add(char key, int value) => adds the specified key and value to the dictionary
            letters.Add(i, 0); 
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters.Add(i, 0);
        }

        foreach (char ch in str)
        {
            // bool ContainsKey(K) => check if there is an ordered pair with this key in the dictionary
            if (letters.ContainsKey(ch))
            {
                letters[ch]++;
            }
        }

        var orderedLetters = letters;   // without additional sorting => a,b,...A,B,...
                //a -> 3
                //b -> 6
                //A -> 5
                //B -> 4
        //var orderedLetters = letters.OrderBy(x => x.Key); //sort by the letter => A,B,..a,b..
                //A -> 5
                //B -> 4
                //a -> 3
                //b -> 6
        //var orderedLetters = letters.OrderByDescending(x => x.Key); //sort by the letter in descending order => ..b,a...B,A
                //b -> 6
                //a -> 3
                //B -> 4
                //A -> 5

        foreach (var letter in orderedLetters)
        {
            if (letter.Value != 0)
            {
                Console.WriteLine("{0} -> {1} ", letter.Key, letter.Value);
            }
        }
        
    }
}