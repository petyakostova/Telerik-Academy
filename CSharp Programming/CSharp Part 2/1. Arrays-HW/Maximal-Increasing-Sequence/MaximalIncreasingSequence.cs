/*  Problem 5. Maximal increasing sequence
    Write a program that finds the maximal increasing sequence in an array.
    Example:
        input 	                    result
        3, 2, 3, 4, 2, 2, 4 	    2, 3, 4
 */
// Note: The increasing elements are consecutively placed.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //Input
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        //Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //Fill an integer array from string array
        int[] elementsArray = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            elementsArray[i] = int.Parse(inputElements[i]);
        }

        int currentLength = 1;
        int maxLength = 0;
        int endIndexBestLength = 0;

        for (int i = 0; i < elementsArray.Length - 1; i++)
        {
            if (elementsArray[i] < elementsArray[i + 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    endIndexBestLength = i;
                }
                currentLength = 1;
            }
        }

        // in case when the last sequence is the maximal sequence of equal elements
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            endIndexBestLength = elementsArray.Length - 1;
        }

        for (int i = endIndexBestLength - maxLength + 1; i <= endIndexBestLength; i++)
        {
            Console.Write(i != endIndexBestLength ? elementsArray[i] + ", " : elementsArray[i] + "\n");
        }       

    }
}