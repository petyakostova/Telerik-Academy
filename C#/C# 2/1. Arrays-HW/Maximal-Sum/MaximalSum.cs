/*  Problem 8. Maximal sum
    Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
    Can you do it with only one loop (with single scan through the elements of the array)?             */

using System;

class MaximalSum
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        int startIndex = 0, bestStart = 0, bestEnd = 0;
        int currentSum = 0, maxSum = int.MinValue;

        for (int i = 0; i < arrayNums.Length; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += arrayNums[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                bestStart = startIndex;
                bestEnd = i;
            }
        }

        Console.WriteLine(maxSum);

        //Print the sequence of maximal sum
        //for (int i = bestStart; i <= bestEnd; i++)
        //{
        //    Console.Write(i != bestEnd ? arrayNums[i] + ", " : arrayNums[i] + "\n");
        //}        

    }
}