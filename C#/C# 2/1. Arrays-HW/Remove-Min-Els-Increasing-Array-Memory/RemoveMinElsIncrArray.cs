/*  Problem 18. Remove elements from array
    Write a program that reads an array of integers and removes from it a minimal number of elements 
    in such a way that the remaining array is sorted in increasing order. 
    Print the minimal number of elements that need to be removed in order for the array to become sorted.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the minimal number of elements that need to be removed
    Constraints: 1 <= N <= 1024                                             */

// This solution requires too much memory

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveMinElsIncrArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        List<List<int>> sequences = new List<List<int>>();
        List<int> currentSequence = new List<int>();

        int counter = 1;
        int start = 0;
        int end = sequences.Count;
        int bestSequenceLength = 1;

        //create a list containing lists of indexes of the elements of the array
        for (int i = 0; i < array.Length; i++)
        {
            List<int> temp1 = new List<int>(1);
            temp1.Add(i);
            sequences.Add(temp1);
        }

        //loop, checking whether the next element of the array can be added to the already found sequences, so that they remain nondecreasing
        while (counter <= array.Length)
        {
            end = sequences.Count;


            for (int i = start; i < end; i++)
            {
                currentSequence = new List<int>();
                currentSequence.AddRange(sequences[i]);

                //inner loop runs from the element to the right of the last found element in the sequence to the end of the array
                for (int j = currentSequence.Last() + 1; j < array.Length; j++)
                {
                    /*If element at index j is >= the element at index, corresponding to the last element of the current sequence,
                      add the current index j to the sequence and add the sequence to the list of sequences; 
                      At the end we will have a list of nondecreasing sequences, 
                      containing the indexes of the actual numbers in the given array.*/
                    if (array[j] >= array[currentSequence.Last()])
                    {
                        List<int> temp = new List<int>();
                        temp.AddRange(currentSequence);
                        temp.Add(j);
                        sequences.Add(temp);
                    }
                }
            }
            start = end;
            counter++;
        }

        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count >= bestSequenceLength)
            {
                bestSequenceLength = sequences[i].Count; //find best sequence's length
            }
        }

        //minimal number of elements for removing so the remaining array is increasing 
        Console.WriteLine(n - bestSequenceLength);

        // print the best sequence/s
        //for (int i = 0; i < sequences.Count; i++)
        //{
        //    if (sequences[i].Count == bestSequenceLength)
        //    {
        //        Console.Write("Best non-decreasing sequence: ");
        //        for (int j = 0; j < bestSequenceLength; j++)
        //        {
        //            Console.Write(array[sequences[i][j]]); //print the actual sequence of corresponding numbers in the array
        //            if (j < bestSequenceLength - 1)
        //            {
        //                Console.Write(", ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
}