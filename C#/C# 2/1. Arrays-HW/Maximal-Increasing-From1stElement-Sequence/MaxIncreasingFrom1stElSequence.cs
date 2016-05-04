/*  Problem 5. Maximal increasing sequence 
    Write a program that finds the length of the maximal increasing sequence in an array of N integers.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the length of the maximal increasing sequence.        */

/* Interpretation: The elements in the maximal sequence must be increasing (not equal) 
                   to the first element of the maximal sequence. */

using System;

class MaxIncreasingFrom1stElSequence
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }

        int maxLength = 1;
        int firstEl = arrayNums[0];
        int count = 1;

        for (int i = 1; i < n; i++)
        {
            if (arrayNums[i] > firstEl)
            {
                count++;
            }
            else
            {
                if (count > maxLength)
                {
                    maxLength = count;
                }

                firstEl = arrayNums[i];
                count = 1;
            }
        }

        // in case when the last sequence is the maximal increasing sequence
        if (count > maxLength)
        {
            maxLength = count;
        }

        Console.WriteLine(maxLength);

    }
}