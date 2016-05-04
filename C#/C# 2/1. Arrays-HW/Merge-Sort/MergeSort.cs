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
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }


    }
}