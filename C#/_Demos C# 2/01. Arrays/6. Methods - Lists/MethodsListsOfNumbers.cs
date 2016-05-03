using System;
using System.Collections.Generic;

class MethodsLists
{
    static void Main()
    {
        // first way for adding a collection
        List<int> listOfNumbers = new List<int>();
        listOfNumbers.AddRange(new[] {1, 2, 3, 4}); // add any collection

        // second way for adding a collection
        List<int> listOfNumbers2 = new List<int>();
        int[] array = { 1, 2, 3, 4 };        
        listOfNumbers2.AddRange(array); 

        // adding other list
        List<int> listOfOtherNumbers = new List<int>();
        List<int> listOfNumbers3 = new List<int>();
        listOfNumbers3.AddRange(listOfOtherNumbers); // add any list (concatinating)

        listOfNumbers.Add(5);   

        foreach (var item in listOfNumbers)
        {
            Console.Write(item + " "); // 1 2 3 4 5 
        }
        Console.WriteLine();

        Console.WriteLine(listOfNumbers[3]);    // 4
        Console.WriteLine(listOfNumbers[4]);    // 5
        //Console.WriteLine(listOfNumbers[5]);    // ArgumentOutOfRangeException - there is not such element

        Console.WriteLine(new string('-', 20));

        List<List<int>> listOfListOfNumbers = new List<List<int>>();
        // the first list ot numbers => listOfListOfNumbers[0]
        // the first element from the first list of numbers => listOfListOfNumbers[0][0] => the easier way for this are the jagged arrays

        // we don't have 0-st list (the first list hasn't got any lists), therefore we can't set by indexes 
        //listOfListOfNumbers[0][0] = 7; // дава ArgumentOutOfRangeException

        // therefore in the list of lists we add a list 
        listOfListOfNumbers.Add(new List<int>());
        // we must add elements to this list too
        listOfListOfNumbers[0].Add(7);   // add element
        Console.WriteLine(listOfListOfNumbers[0][0]);
        //Console.WriteLine(listOfListOfNumbers[0][1]); //System.ArgumentOutOfRangeException

        // clear all elements => empty list in 0 elements
        listOfNumbers2.Clear();  
        //Console.WriteLine(listOfNumbers2[0]); // дава ArgumentOutOfRangeException

        Console.WriteLine(listOfNumbers.Contains(4));   // True
        Console.WriteLine(listOfNumbers.Contains(123)); // False

        Console.WriteLine(listOfNumbers.Count); // returns the range of the list => 5
        Console.WriteLine(listOfNumbers.IndexOf(4)); // returns the index of the founded given number => 3
        Console.WriteLine(listOfNumbers.IndexOf(123)); // if there is not such number in the list => returns -1

        List<int> listOfNumbers5 = new List<int>();
        listOfNumbers5.AddRange(new[] { 3, 1, 2, 3, 4, 3 });

        // Removes the first occurrence of a specific object from the System.Collections.Generic.List`1.
        Console.WriteLine("listOfNumbers5.Remove(3)= " + listOfNumbers5.Remove(3));    
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 1 2 3 4 3
        }
        Console.WriteLine();

        listOfNumbers5.RemoveAll(x => x == 3); // removes all 3-s
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 1 2 4
        }
        Console.WriteLine();

        listOfNumbers5.Reverse();   // обръща списъка наобратно
        foreach (var item in listOfNumbers5)
        {
            Console.Write(item + " ");  // 4 2 1
        }
        Console.WriteLine();

        List<int> listOfNumbers6 = new List<int>();
        listOfNumbers6.AddRange(new[] { 7, 2, 3, 6, 5, 1, 4 });
        listOfNumbers6.Sort();  // сортира списъка
        foreach (var item in listOfNumbers6)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}