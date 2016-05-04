/*  Problem 6. Maximal K sum - Consecutive
    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum - print them and the maximal sum.
 */

// Interpretation: The elements are consecutively placed.
// The solution is not for bgcoder!

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

        string maxSeq = "";
        int sum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            string currentSeq = "";

            // out of the array bounds
            if (i + k > array.Length)
            {
                break;
            }

            // set current sum
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
                currentSeq += array[j].ToString() + ' ';
            }

            // max sum check
            if (sum > maxSum)
            {
                maxSeq = currentSeq;
                maxSum = sum;
            }

            sum = 0;
        }

        // output
        Console.WriteLine(maxSeq);
        Console.WriteLine(maxSum);

    }
}