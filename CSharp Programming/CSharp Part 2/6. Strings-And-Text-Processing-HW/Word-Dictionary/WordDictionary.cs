/*  Problem 14. Word dictionary
    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.
    Sample dictionary:
                        input 	        output
                        .NET 	        platform for applications from Microsoft
                        CLR 	        managed execution environment for .NET
                        namespace 	    hierarchical organization of classes
 */

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>()        //using System.Collections.Generic;
        {
            {".NET", "platform for applications from Microsoft"},
            {"CLR", "managed execution environment for .NET"},
            {"NAMESPACE", "hierarchical organization of classes"}
        };
        //// void Add(K, V) => adds a new pair (key and a value) to the dictionarty => throws an exception if the key exists
        //dictionary.Add(".NET", "platform for applications from Microsoft");
        //dictionary.Add("CLR", "managed execution environment for .NET");
        //dictionary.Add("namespace", "hierarchical organization of classes");

        Console.WriteLine("Dictionary words: {0}\n", string.Join(", ", dictionary.Keys));
        Console.WriteLine("Enter a word to see its translation or type \"exit\" to leave: ");
        // By default the strings in .NET are case sensitive (the compiler distinguishes uppercase from lowercase letters)
        string input = Console.ReadLine().ToUpper();    
        
        while (input != "EXIT")
        {
            // bool ContainsKey(K) => check if there is an ordered pair with this key in the dictionary
            if (dictionary.ContainsKey(input))  
            {
                Console.WriteLine(dictionary[input]);
            }
            else
            {
                Console.WriteLine("There is not such word in the dictionary.");
            }
            Console.WriteLine("Enter a word to see its translation or type EXIT to leave: ");
            input = Console.ReadLine().ToUpper();
        }
    }
}