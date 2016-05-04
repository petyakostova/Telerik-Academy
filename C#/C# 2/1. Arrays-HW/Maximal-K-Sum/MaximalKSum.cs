/*  Problem 6. Maximal K sum
    Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    On the first line you will receive the number N. On the second line you will receive the number K.
    On the next N lines the numbers of the array will be given.
    Find the maximal sum of K elements in the array.                 */

// Interpretation: It is not necessary the elements to be consecutively placed.

using System;

class MaximalKSum
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine()); // size of the array
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);
        int maxSum = 0;

        for (int i = 0; i < k; i++)
        {
            maxSum += array[i];
            // print the k elements that have maximal sum 
            //Console.Write(i != k - 1 ? array[i] + ", " : array[i] + "\n");
        }

        Console.WriteLine(maxSum);
    }
}