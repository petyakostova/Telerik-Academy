/*  Problem 14. Quick sort
    Write a program that sorts an array of integers using the Quick sort algorithm.
 */

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        // 2, 3, 5, 0, 123, 3, 23, 1234, 87
        // Input array
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        // Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Fill an integer array from string array
        int[] array = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            array[i] = int.Parse(inputElements[i]);
        }

        // Converting array to list   
        List<int> arrayList = new List<int>(array);

        List<int> sortedArray = QuickSorting(arrayList);
        
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write(i != sortedArray.Count - 1 ? sortedArray[i] + ", " : sortedArray[i] + "\n");
        } 

    }
    
    static List<int> QuickSorting(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }

        int pivot = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivot];

        unsortedList.RemoveAt(pivot);

        List<int> less = new List<int>();
        List<int> greater = new List<int>();

        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                less.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }

        List<int> result = new List<int>();

        result.AddRange(QuickSorting(less));
        result.Add(pivotValue);
        result.AddRange(QuickSorting(greater));

        return result;

    }
    
}