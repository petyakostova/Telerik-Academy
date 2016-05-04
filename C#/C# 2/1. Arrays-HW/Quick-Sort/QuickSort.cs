/*  Problem 14. Quick sort
    Write a program that sorts an array of integers using the Quick sort algorithm.
    Input: On the first line you will receive the number N. On the next N lines the numbers of the array will be given
    Output: Print the sorted array. Each number should be on a new line
    Constraints: 1 <= N <= 1024                                              */

using System;
using System.Collections.Generic;

class QuickSort
{
    static void Main()
    {
        // Input 
        int n = int.Parse(Console.ReadLine());
        var array = new int[n];        
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Converting array to list   
        List<int> arrayList = new List<int>(array);

        List<int> sortedArray = QuickSorting(arrayList);
        
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.WriteLine(sortedArray[i]);
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

        //public void RemoveAt(int index); => Removes the element at the specified index 
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
        
        // Add the elements of the specified collection to the end of the System.Collections.Generic.List`1.
        result.AddRange(QuickSorting(less)); //public void AddRange(IEnumerable<T> collection)
        result.Add(pivotValue);
        result.AddRange(QuickSorting(greater));

        return result;
    }
    
}