/*  Problem 10. Find sum in array
    Write a program that finds in given array of integers a sequence of given sum S (if present).
    Example:
        array 	                    S 	    result
        4, 3, 1, 4, 2, 5, 8 	    11 	    4, 2, 5
 */
// Note: The elements are consecutively placed.

using System;

class FindSumInArray
{
    static void Main()
    {
        // Input array
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        // Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Fill an integer array from string array
        int[] arrayNums = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            arrayNums[i] = int.Parse(inputElements[i]);
        }

        // Input S
        Console.WriteLine("Enter the sum S = ");
        int s = int.Parse(Console.ReadLine());

        // The first loop assigns a starting index
        for (int i = 0; i < arrayNums.Length; i++)
        {
            int sum = 0;

            /* The second loop sums the elements from the starting index to the right 
             * until this partial sum reaches or is greater than S. */
            for (int j = i; j < arrayNums.Length; j++)
            {
                sum = sum + arrayNums[j];                

                if (sum > s)
                {
                    sum = 0;
                    break;
                }

                // If the sum is equal to S, we remember the starting index (from the first loop) and the ending index (from the second loop).
                if (sum == s)
                {
                    for (int index = i; index <= j; index++)
                    {
                        Console.Write(index != j ? arrayNums[index] + ", " : arrayNums[index] + "\n");
                    }
                }
            }
        }


    }
}