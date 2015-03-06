/*  Problem 8. Maximal sum
    Write a program that finds the sequence of maximal sum in given array.
    Example:
        input 	                                result
        2, 3, -6, -1, 2, -1, 6, 4, -8, 8 	    2, -1, 6, 4
    Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class MaximalSum
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

        int startIndex = 0, currentSum = 0;
        int bestStart = 0, bestEnd = 0, maxSum = int.MinValue;

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
      
        Console.Write("Sequence of maximal sum: ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write(i != bestEnd ? arrayNums[i] + ", " : arrayNums[i] + "\n");
        }
        Console.WriteLine("Maximal sum: {0}", maxSum);
        
    }
}