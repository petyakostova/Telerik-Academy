/*  Problem 5. Maximal increasing sequence
    Write a program that finds the length of the maximal increasing sequence in an array of N integers.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the length of the maximal increasing sequence                 */

// Note: The increasing elements are consecutively placed.

using System;

class MaximalIncreasingSequence
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
        
        int currentLength = 1;
        int maxLength = 0;
        //int endIndexBestLength = 0;

        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            if (arrayNums[i] <= arrayNums[i + 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    //endIndexBestLength = i;
                }
                currentLength = 1;
            }
        }

        // in case when the last sequence is the maximal increasing sequence
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            //endIndexBestLength = arrayNums.Length - 1;
        }

        Console.WriteLine(maxLength);

        //for (int i = endIndexBestLength - maxLength + 1; i <= endIndexBestLength; i++)
        //{
        //    Console.Write(i != endIndexBestLength ? arrayNums[i] + ", " : arrayNums[i] + "\n");
        //}       

    }
}