/*  Problem 4. Appearance count
    Write a method that counts how many times given number appears in given array.
    Write a test program to check if the method is workings correctly.
 */

using System;

class HowManyTimesNumberInArray
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int numberToCount = int.Parse(Console.ReadLine());

        int[] arrayInput = ArrayReader();

        int counter = Counter(numberToCount, arrayInput);

        Console.WriteLine("Times of appearing: {0}", counter);

    }

    static int[] ArrayReader()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] arrayInput = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("element[{0}] = ", i);
            arrayInput[i] = int.Parse(Console.ReadLine());              
        }
        return arrayInput;
    }
    
    static int Counter(int number, params int[] array)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }

        return counter;
    }
    
}