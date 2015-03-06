/*  Problem 5. Sort by string length
    You are given an array of strings. 
    Write a method that sorts the array by the length of its elements (the number of characters composing them).
 */

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element {0} : ", i + 1);
            array[i] = Console.ReadLine();
        }

        string exchanger = null;
        int indexer = 0;
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            exchanger = array[i];
            counter = 0;
            for (int j = i; j < n; j++)
            {
                if (array[j].Length > counter)
                {
                    counter = array[j].Length;
                    indexer = j;
                    exchanger = array[j];
                }
            }
            array[indexer] = array[i];
            array[i] = exchanger;
        }

        Array.Reverse(array);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}