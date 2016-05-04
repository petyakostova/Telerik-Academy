/*  Problem 9. Frequent number
    Write a program that finds the most frequent number in an array of N elements.
    Print the most frequent number and how many time it is repeated.
        Output should be REPEATING_NUMBER (REPEATED_TIMES times)                 */

using System;

class FrequentNumber
{
    static void Main()
    {
        //input
        int n = int.Parse(Console.ReadLine());
        int[] arrayNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrayNums[i] = int.Parse(Console.ReadLine());
        }
        
        // sorting the numbers in ascending order, so the elements with same value will be placed next to each other
        Array.Sort(arrayNums);

        // find the longest sequence of neighbor equal elements
        int count = 1;
        int repeatCountBest = 0; // repeated times
        int repeatingNumBest = 0;

        for (int i = 0; i < arrayNums.Length - 1; i++)
        {
            if (arrayNums[i] == arrayNums[i + 1])
            {
                count++;
            }
            else
            {
                if (count > repeatCountBest)
                {
                    repeatCountBest = count;
                    repeatingNumBest = arrayNums[i];
                }
                count = 1;
            }
        }

        // in case when the last sequence is the maximal sequence of equal elements
        if (count > repeatCountBest)
        {
            repeatCountBest = count;
            repeatingNumBest = arrayNums[arrayNums.Length - 1];
        }

        // output
        Console.WriteLine("{0} ({1} times)", repeatingNumBest, repeatCountBest);
        
    }
}