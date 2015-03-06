/*  Problem 9. Frequent number
    Write a program that finds the most frequent number in an array.
    Example:
        input 	                                    result
        4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 	    4 (5 times)
 */

using System;

class FrequentNumber
{
    static void Main()
    {
        //Input
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        //Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //Fill an integer array from string array
        int[] arrayNums = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            arrayNums[i] = int.Parse(inputElements[i]);
        }

        // sorting the numbers in ascending order, so the elements with same value will be placed next to each other
        Array.Sort(arrayNums);

        // find the longest sequence of neighbor equal elements
        int currentLength = 1;
        int maxLength = 0;
        int elementBestLength = 0;

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
                    elementBestLength = arrayNums[i];
                }
                currentLength = 1;
            }
        }
        // in case when the last sequence is the maximal sequence of equal elements
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            elementBestLength = arrayNums[arrayNums.Length - 1];
        }

        // output
        Console.WriteLine("{0} ({1} times)", elementBestLength, maxLength);
        
    }
}