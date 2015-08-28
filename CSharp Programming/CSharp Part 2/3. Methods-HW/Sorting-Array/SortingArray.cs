/*  Problem 9. Sorting array
    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
 */

using System;

class MaxElementInAPortionOfArray
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        ArrayInput(array);

        Console.WriteLine("Enter a position (index), from which to start the search [from 0 to {0}]: ", length - 1);
        int position = int.Parse(Console.ReadLine());

        int maxPosition = 0;
        int maxElement = MaxElement(position, array, ref maxPosition, array.Length);//the last var is for the other tasks
        Console.WriteLine("The maximum element is {0} at position {1}. ", maxElement, maxPosition);

        int[] arrayInputAscending = new int[length];
        int[] arrayInputDescending = new int[length];

        Array.Copy(array, arrayInputAscending, length);
        Array.Copy(array, arrayInputDescending, length);

        AscendingSorter(arrayInputAscending);
        DescendingSorter(arrayInputDescending);

        Console.WriteLine("The array is:");
        PrintArray(array);
        Console.WriteLine();

        Console.WriteLine("The Sorted array in ascending order is:");
        PrintArray(arrayInputAscending);
        Console.WriteLine();

        Console.WriteLine("The Sorted array in descending order is:");
        PrintArray(arrayInputDescending);
        Console.WriteLine();
    }

    static void ArrayInput(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static int MaxElement(int startPosition, int[] array, ref int maxPos, int finishPosition)
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
            max = MaxElement(0, array, ref maxPosition, array.Length - i);
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
            max = MaxElement(i, array, ref maxPosition, array.Length);
            array[maxPosition] = array[i];
            array[i] = max;
        }
    }
}