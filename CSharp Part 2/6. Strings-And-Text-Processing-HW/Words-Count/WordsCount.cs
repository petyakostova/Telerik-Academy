/*  Problem 22. Words count
    Write a program that reads a string from the console and 
    lists all different words in the string along with information how many times each word is found.
 */

using System;
using System.Collections.Generic; // needed for Dictionary and List<string>
using System.Linq;                // needed for OrderBy, OrderByDescending, Distinct() and Count()

class WordsCount
{
    static void Main()
    {
        //// the real input
        //string str = Console.ReadLine();
        // input for faster testing
        string str = "Telerik Academy Nindja Programming Nindja programming Telerik Nindja";

        // first way - with Dictionary<string, int>
        string[] onlyWords = str.Split(new char[] { ' ', ',', '.', '-', '!', ':' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> allWords = new Dictionary<string, int>();
        foreach (string word in onlyWords)
        {
            if (allWords.ContainsKey(word))
            {
                allWords[word]++;
            }
            else
            {
                allWords.Add(word, 1);
            }
        }

        //var orderedWords = allWords;    // in order of appearance
        var orderedWords = allWords.OrderByDescending(x => x.Value);    // ordered by times found (value) in descending order
        //var orderedWords = allWords.OrderBy(x => x.Key);    // ordered by keys

        foreach (var word in orderedWords)
        {
            Console.WriteLine("{0} -> {1} ", word.Key, word.Value);
        }

        //// second way - with List<string>        
        //List<string> listOnlyWords = new List<string>(str.Split(new char[] { ' ', ',', '.', '-', '!', ':' }, StringSplitOptions.RemoveEmptyEntries));

        //List<string> allWords = listOnlyWords.Distinct().OrderBy(c => c).ToList();

        //foreach (string word in allWords)
        //{
        //    Console.WriteLine("{0} -> {1}", word, listOnlyWords.Count(x => x == word));
        //}

    }
}