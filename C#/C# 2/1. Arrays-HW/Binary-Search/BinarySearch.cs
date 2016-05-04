/*  Problem 11. Binary search
    Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
            On the last line you will receive the number X
    Output:
            Print the index where X is in the array
                If there is more than one occurence print the first one
                If there are no occurences print -1                              */

using System;

class BinarySearch
{
    static void Main()
    {
        // Input 
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }
        int element = int.Parse(Console.ReadLine()); //the element, whose index You want to find

        // Binary search works only on sorted arrays.
        Array.Sort(arrayNums);

        int left = 0;
        int right = arrayNums.Length - 1;
        int middle = 0;
        int index = -1;

        while (right >= left)
        {
            middle = (left + right) / 2;
            if (arrayNums[middle] < element)
            {
                left = middle + 1;
            }
            else if (arrayNums[middle] > element)
            {
                right = middle - 1;
            }
            else  // array[middle] == element 
            {
                index = middle;
                break;
            }
        }

        Console.WriteLine(index);

    }
}