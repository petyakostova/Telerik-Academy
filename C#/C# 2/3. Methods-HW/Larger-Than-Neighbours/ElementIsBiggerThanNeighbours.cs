/*  5. Larger than neighbours
    Write a method that checks if the element at given position in given array of integers 
    is larger than its two neighbours (when such exist). 
    Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
    Input:
            On the first line you will receive the number N - the size of the array
            On the second line you will receive N numbers separated by spaces - the array
    Output: Print how many numbers in the array are larger than their neighbours
    Constraints: 1 <= N <= 1024
    Sample tests: 
    Input 	                Output
    6
    -26 -25 -28 31 2 27 	2           */

using System;

class ElementIsBiggerThanNeighbours
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        ArrayInput(length, array);

        Console.WriteLine(LargerThanNeighboursCount(length, array));
    }

    static void ArrayInput(int length, int[] array)
    {
        string[] numbersAsText = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(numbersAsText[i]);
        }
    }

    static int LargerThanNeighboursCount(int length, int[] array)
    {
        int count = 0;

        for (int i = 1; i < length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                count++;
            }
        }

        return count;
    }

}