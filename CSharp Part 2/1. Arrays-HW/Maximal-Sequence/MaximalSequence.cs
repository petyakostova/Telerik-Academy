/*  Problem 4. Maximal sequence
    Write a program that finds the maximal sequence of equal elements in an array.
    Example:
        input 	                            result
        2, 1, 1, 2, 3, 3, 2, 2, 2, 1 	    2, 2, 2
 */
// Note: The equal elements are consecutively placed.
using System;

class MaximalSequence
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

        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(i != maxLength - 1 ? elementBestLength + ", " : elementBestLength + "\n");
        }       

    }
}