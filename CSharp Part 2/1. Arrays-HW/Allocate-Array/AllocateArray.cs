/*  Problem 1. Allocate array
    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
 */
using System;

class AllocateArray
{
    static void Main()
    {
        var intArray = new int[20];   //int[] intArray = new int[20];

        for (int index = 0; index < intArray.Length; index++)
        {
            intArray[index] = 5 * index;
        }

        for (int index = 0; index < intArray.Length; index++)
        {
            Console.WriteLine("element[{0}] = {1}", index, intArray[index]);
        }
    }
}