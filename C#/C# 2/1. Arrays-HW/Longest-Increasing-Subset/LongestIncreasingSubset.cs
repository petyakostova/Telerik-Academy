/*  Problem 18. Remove elements from array
    Write a program that reads an array of integers and removes from it a minimal number of elements 
    in such a way that the remaining array is sorted in increasing order. 
    Print the minimal number of elements that need to be removed in order for the array to become sorted.
    Input:
            On the first line you will receive the number N
            On the next N lines the numbers of the array will be given
    Output: Print the minimal number of elements that need to be removed
    Constraints: 1 <= N <= 1024                                             */

using System;
using System.Collections.Generic;

class LongestIncreasingSubset
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        List<int> longestSequenceList = new List<int>();

        //Find the longest sequence of identical elements
        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;

        for (int i = 0; i < array.Length - 1; i++) //could start on index 1 and check current with previous elements
        {
            if (array[i] == array[i + 1])
            {
                currentCount++;

                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        //Make the sequence currently longest
        for (int i = 0; i < lenghtCount; i++)
        {
            longestSequenceList.Add(array[startIndex + i]);
        }

        //Find how many combinations of sequences can be there
        long combinations = 1;
        for (int i = 0; i < array.Length; i++) //Instead of Math.Pow
        {
            combinations *= 2;
        }

        for (long combination = 1; combination <= combinations; combination++)
        {
            //convert current combination number to its binary representation.
            //That way we will use the positions with bit "1" with the elements on the same position in the array
            string binary = Convert.ToString(combination, 2).PadLeft(array.Length, '0');
            char[] tempArr = binary.ToCharArray();
            Array.Reverse(tempArr);
            string revBinary = new string(tempArr);

            List<int> tempList = new List<int>();
            int bitsCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (revBinary[i] == '1')
                {
                    tempList.Add(array[i]);
                    bitsCount++;
                }
            }

            if (bitsCount < longestSequenceList.Count) //Speed optimisation
            {
                continue;
            }

            int currentLenght = 0;
            List<int> currentLongestSeq = new List<int>();

            if (tempList.Count > 1) //Avoid cases where the current combination will use only 1 element
            {
                int biggestNum = tempList[0];
                currentLongestSeq.Add(biggestNum);

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    //If the next number in the current combination sequence is bigger add it to final list
                    if (tempList[i + 1] > biggestNum)
                    {
                        biggestNum = tempList[i + 1];

                        currentLongestSeq.Add(biggestNum);
                    }
                }

                currentLenght = currentLongestSeq.Count;
            }

            if (currentLenght > longestSequenceList.Count)
            {
                longestSequenceList = currentLongestSeq;
            }
        }

        //Output
        for (int i = 0; i < longestSequenceList.Count; i++)
        {
            Console.Write(longestSequenceList[i] + " ");
        }
        Console.WriteLine();
    }
}