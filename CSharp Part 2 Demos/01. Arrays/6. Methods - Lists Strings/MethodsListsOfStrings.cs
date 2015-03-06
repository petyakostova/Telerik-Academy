using System;
using System.Collections.Generic;
using System.Linq;

class MethodsLists
{
    static void Main()
    {
        List<string> listOfWords = new List<string>();
        listOfWords.AddRange(new[] { "Orange", "Strawberry", "cocoa", "apple", "see", "as" });

        string[] arrayOfWords = listOfWords.ToArray();   // връща масив от ел-тите в списъка

        listOfWords.Sort();  // сортира списъка
        foreach (var item in listOfWords)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));

        // needed System.Linq;
        listOfWords = listOfWords
            .OrderBy(x => x.Length) // подреди списъка по големина (брой на символите) 
            .ToList();  //и ми го върни в лист
        foreach (var item in listOfWords)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));

        listOfWords = listOfWords
            .Where(x => x[0] == 'a') // искам всички символни низове, в които първата буква е а
            .ToList();  //и ми го върни в лист
        foreach (var item in listOfWords)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
    }
}