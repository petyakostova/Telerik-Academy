/*  Problem 1. Allocate array
    Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.
 */

using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var intArray = new int[n];   //int[] intArray = new int[n];

        for (int index = 0; index < intArray.Length; index++)
        {
            intArray[index] = 5 * index;
        }

        foreach (var item in intArray)
        {
            Console.WriteLine(item);
        }

    }
}