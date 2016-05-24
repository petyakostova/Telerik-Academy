/*  24. Order words
    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */

using System;
using System.Linq;  // needed for OrderBy() and Select()

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter a list of words, separated by spaces: ");

        string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // first way

        //var ordered = words.OrderBy(x => x);

        //Console.WriteLine("\nWords sorted in alphabetical order:");

        //foreach (var item in ordered)
        //{
        //    Console.WriteLine(item);
        //}

        // second way

        //Array.Sort(words);

        //Console.WriteLine("\nWords sorted in alphabetical order:\n{0}\n",
        //    string.Join("\n", words.Select(x => string.Format("=> {0}", x))));

    }
}