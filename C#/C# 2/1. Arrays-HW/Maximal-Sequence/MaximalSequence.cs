/*  Problem 4. Maximal sequence
    Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
    Input: 
    On the first line you will receive the number N
    On the next N lines the numbers of the array will be given
    Output: Print the length of the maximal sequence                 */

// Interpretation: The equal elements are consecutively placed.

using System;

class MaximalSequence
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
        //int elementBestLength = 0;

        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            if (arrayNums[i] == arrayNums[i + 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    //elementBestLength = arrayNums[i];
                }
                currentLength = 1;
            }
        }

        // in case when the last sequence is the maximal sequence of equal elements
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            //elementBestLength = arrayNums[arrayNums.Length - 1];
        }

        Console.WriteLine(maxLength);

        //for (int i = 0; i < maxLength; i++)
        //{
        //    Console.Write(i != maxLength - 1 ? elementBestLength + ", " : elementBestLength + "\n");
        //}

    }
}