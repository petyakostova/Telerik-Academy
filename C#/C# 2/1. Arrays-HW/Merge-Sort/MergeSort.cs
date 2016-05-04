/* Problem 13. Merge sort
   Write a program that sorts an array of integers using the Merge sort algorithm.
   Input: 
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
   Output:  Print the sorted array. Each number should be on a new line.
   Constraints: 1 <= N <= 1024                                                */

using System;

class MergeSort
{
    static int[] arrayNums;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        MergeSort(0, arrayNums.Length - 1);

        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.WriteLine(arrayNums[i]);
        }
    }

    static void MergeSort(int start, int end)
    {
        // Array with 1 element
        if (start >= end) return;

        // Define a middle of the array
        int middle = (start + end) / 2;

        MergeSort(start, middle);
        MergeSort(middle + 1, end);

        CompareAndSort(start, middle, end);
    }

    static void CompareAndSort(int start, int middle, int end)
    {
        int[] sortedArr = new int[arrayNums.Length];

        int valuesLocalArr = start; // for saving the values of the local array, which always starts from start
        int leftArrStart = start; // for the beginning of the left array
        int middleArrStart = middle + 1; // where starts the right sub-array <=> the left range ot the right sub-array

        //inserting the smaller numbers
        while (leftArrStart <= middle && middleArrStart <= end)
        {
            if (arrayNums[leftArrStart] > arrayNums[middleArrStart])
            {
                sortedArr[valuesLocalArr++] = arrayNums[middleArrStart++];
            }
            else
            {
                sortedArr[valuesLocalArr++] = arrayNums[leftArrStart++];
            }
        }

        //inserting other numbers
        while (leftArrStart <= middle)
        {
            sortedArr[valuesLocalArr++] = arrayNums[leftArrStart++];
        }

        while (middleArrStart <= end)
        {
            sortedArr[valuesLocalArr++] = arrayNums[middleArrStart++];
        }

        for (int i = start; i <= end; i++)
        {
            arrayNums[i] = sortedArr[i];
        }
    }

}