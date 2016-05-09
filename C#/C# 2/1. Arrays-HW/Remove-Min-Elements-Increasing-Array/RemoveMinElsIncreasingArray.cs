/*  Problem 18. Remove elements from array
    Write a program that reads an array of integers and removes from it a minimal number of elements 
    in such a way that the remaining array is sorted in increasing order. 
    Print the minimal number of elements that need to be removed in order for the array to become sorted.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the minimal number of elements that need to be removed
    Constraints: 1 <= N <= 1024                                             */

// Algorithm => http://www.algorithmist.com/index.php/Longest_Increasing_Subsequence

using System;

class RemoveMinElsIncreasingArray
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSubseqLength = 0;
        int[] helperArray = new int[n]; // helper array storing sequence length for each element

        // for each EndPoint access each subsequence in the array  
        for (int endPoint = 0; endPoint < array.Length; endPoint++)
        {
            maxSubseqLength = 0;

            // for each start point then set a StartPoint => 0 to EndPoint                              
            for (int startPoint = 0; startPoint < endPoint; startPoint++)
            {
                // if current StartPoint element is smaller than the at EndPoint they are members of the same sequence
                if (array[startPoint] <= array[endPoint]
                    && helperArray[startPoint] >= maxSubseqLength) 
                    // if the length for the element before is larger than the current MaxSequenceLength
                {
                    // max equals the length for the current element
                    maxSubseqLength = helperArray[startPoint];
                }
            }

            // Longest existing sequence
            helperArray[endPoint] = maxSubseqLength + 1;
        }

        // Find the max length of subsequence amongst all subsequence lengths
        maxSubseqLength = 0;
        for (int i = 0; i < n; i++)
        {
            // Length stored in the helper array                      
            if (helperArray[i] > maxSubseqLength)
            {
                maxSubseqLength = helperArray[i];
            }
        }

        // Output
        Console.WriteLine(n - maxSubseqLength);

    }
}