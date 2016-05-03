using System;
using System.Collections.Generic;
using System.Linq;

class MethodsLists
{
    static void Main()
    {
        List<string> listOfWords = new List<string>();
        listOfWords.AddRange(new[] { "Orange", "Strawberry", "cocoa", "apple", "see", "as", "as" });

        string[] arrayOfWords = listOfWords.ToArray();   // returns array from the elements in the list

        listOfWords.Sort();  // sort the list
        foreach (var item in listOfWords)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));

        // needed System.Linq;
        listOfWords = listOfWords
            .OrderBy(x => x.Length) // ordering list by length (number of symbols) 
            .ToList();              // and return it to list
        foreach (var item in listOfWords)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));

        listOfWords = listOfWords
            .Where(x => x[0] == 'a') // wanted all strings, which first letter is 'a'
            .ToList();               // and return it to list
        foreach (var item in listOfWords)
        {
            Console.Write(item + " "); // as as apple
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));

        listOfWords.Remove("as");
        foreach (var item in listOfWords)
        {
            Console.Write(item + " "); // as apple
        }
        Console.WriteLine();
    }
}