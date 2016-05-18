/*  9. Sorting array
    Write a method that returns the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order. 
    Write a program that sorts a given array.
    Input:
            On the first line you will receive the number N - the size of the array
            On the second line you will receive N numbers separated by spaces - the array
    Output: Print the sorted array. Elements must be separated by spaces
    Constraints: 1 <= N <= 1024
    Sample tests:
    Input 	                            Output
    6
    3 4 1 5 2 6 	                    1 2 3 4 5 6

    10
    36 10 1 34 28 38 31 27 30 20 	    1 10 20 27 28 30 31 34 36 38                    */

using System;
using System.Linq;

class MaxElementInAPortionOfArray
{
    static void Main()
    {
        // Input
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        array = ArrayInput(array);
        //ArrayInputWithLength(length, array); // other way for parsing the array

        // Max Position
        int position = 0; // the position, from which to start the search
        int maxPosition = 0; // the position of the max element
        /* static int MaxElementInArray(int[] array, int startPosition, int finishPosition, ref int maxPos)
           the last var is for the other tasks */
        int maxElement = MaxElementInArray(array, position, array.Length, ref maxPosition);

        int[] arrayInputAscending = new int[length];
        int[] arrayInputDescending = new int[length];

        // public static void Copy(Array sourceArray, Array destinationArray, int length);
        Array.Copy(array, arrayInputAscending, length);
        Array.Copy(array, arrayInputDescending, length);

        AscendingSorter(arrayInputAscending);
        DescendingSorter(arrayInputDescending);

        //PrintArray(array); // the initial array

        // The Sorted array in ascending order
        PrintArray(arrayInputAscending);

        //Console.WriteLine();

        // The Sorted array in descending order
        //PrintArray(arrayInputDescending);

        //Console.WriteLine();
    }

    // I way: parsing the input in array
    static int[] ArrayInput(int[] array)
    {
        return array = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
    }

    // II way: parsing the input in array using length
    //static void ArrayInputWithLength(int length, int[] array)
    //{
    //    string[] numbersAsText = Console.ReadLine()
    //        .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

    //    for (int i = 0; i < length; i++)
    //    {
    //        array[i] = int.Parse(numbersAsText[i]);
    //    }
    //}

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                Console.Write(array[i] + " ");
            }
            else
            {
                Console.Write(array[i]);
            }

        }
    }

    static int MaxElementInArray(int[] array, int startPosition, int finishPosition, ref int maxPos)
    {
        int maxEl = array[startPosition];
        maxPos = startPosition;

        for (int i = startPosition; i < finishPosition; i++)
        {
            if (maxEl < array[i])
            {
                maxEl = array[i];
                maxPos = i;
            }
        }

        return maxEl;
    }

    static void AscendingSorter(int[] array)
    {
        int max = 0;
        int maxPosition = 0;

        for (int i = 0; i < array.Length; i++)
        {
            max = MaxElementInArray(array, 0, array.Length - i, ref maxPosition);
            array[maxPosition] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = max;
        }
    }

    static void DescendingSorter(int[] array)
    {
        int max = 0;
        int maxPosition = 0;

        int[] SortedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            max = MaxElementInArray(array, i, array.Length, ref maxPosition);
            array[maxPosition] = array[i];
            array[i] = max;
        }
    }
}