/*  Problem 11. Binary search
    Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
 */

using System;

class BinarySearch
{
    static void Main()
    {
        // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        // Input array
        Console.WriteLine("Enter an array of integer elements on a single line, separated by commas:");
        string input = Console.ReadLine();

        // Split the elements into an array
        string[] inputElements = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Fill an integer array from string array
        int[] array = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            array[i] = int.Parse(inputElements[i]);
        }

        // Input Number
        Console.WriteLine("Enter the element, whose index You want to find: ");
        int element = int.Parse(Console.ReadLine());

        // Binary search works only on sorted arrays.
        Array.Sort(array);

        int left = 0;
        int right = array.Length - 1;
        int middle = 0;
        int index = -1;
      
        while (right >= left)
        {
            middle = (left + right) / 2;
            if (array[middle] < element)
            {
                left = middle + 1;
            }
            else if (array[middle] > element)
            {
                right = middle - 1;
            }
            else  // array[middle] == element 
            {
                index = middle;
                break;
            }
        }

        if (index != -1)
        {
            Console.WriteLine("The index of the given element is: {0}", index);
        }
        else
        {
            Console.WriteLine("There is no number {0} in the array.", element);
        }
        
    }
}