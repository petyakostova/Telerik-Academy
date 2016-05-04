/*  Problem 18. Remove elements from array
    Write a program that reads an array of integers and removes from it a minimal number of elements 
    in such a way that the remaining array is sorted in increasing order. 
    Print the minimal number of elements that need to be removed in order for the array to become sorted.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the minimal number of elements that need to be removed
    Constraints: 1 <= N <= 1024                                             */

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveMinElsIncreasingArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        
    }
}