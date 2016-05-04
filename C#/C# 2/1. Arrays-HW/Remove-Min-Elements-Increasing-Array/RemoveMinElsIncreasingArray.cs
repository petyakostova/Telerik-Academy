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
        var array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSeqLength = 0;
        var helperArray = new int[n]; // helper array storing sequence length for each element

        // For each EndPoint access each subsequence in the array. Set an EndPoint 0 to Length     
        for (int endPoint = 0; endPoint < array.Length; endPoint++)
        {
            maxSeqLength = 0;
            // For each start point then set a Start Point 0 to EndPoint                              
            for (int startPoint = 0; startPoint < endPoint; startPoint++)
            {
                // If current Start Point element is smaller than the at End Point they are members of the same sequence
                if (array[endPoint] >= array[startPoint])
                {
                    if (helperArray[startPoint] > maxSeqLength)  // if the length for the element before is 
                    {                                            // larger than the current MaxSequenceLength
                        maxSeqLength = helperArray[startPoint];  // Max equals the length for the current 
                    }                                            // element
                }                                                // The Element at End Point Belogs to that
            }                                                    // sequence

            // Longest existing sequence
            // the current EndPoint element belogs to plus the current element sequence of at least 1 elements
            helperArray[endPoint] = maxSeqLength + 1;
        }

        maxSeqLength = 0;
        // Find the Max
        for (int i = 0; i < n; i++)
        {
            // Length stored in the helper array                      
            if (helperArray[i] > maxSeqLength)
            {
                maxSeqLength = helperArray[i];
            }
        }

        Console.WriteLine(n - maxSeqLength);

    }
}