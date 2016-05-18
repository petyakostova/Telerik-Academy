/*  4. Appearance count
    Write a method that counts how many times given number appears in a given array. 
    Write a test program to check if the method is working correctly.
    Input:
    On the first line you will receive a number N - the size of the array
    On the second line you will receive N numbers separated by spaces - the numbers in the array
    On the third line you will receive a number X
    Output: Print how many times the number X appears in the array
    Constraints: 1 <= N <= 1024 */

using System;

class HowManyTimesNumberInArray
{
    static void Main()
    {
        int[] arrayInput = ArrayReader();

        int numberToCount = int.Parse(Console.ReadLine());

        int counter = Counter(numberToCount, arrayInput);

        Console.WriteLine(counter);

    }

    static int[] ArrayReader()
    {
        int arrayLength = int.Parse(Console.ReadLine());

        string[] numbersAsText = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        int[] arrayInput = new int[arrayLength];       
         
        for (int i = 0; i < arrayLength; i++)
        {
            arrayInput[i] = int.Parse(numbersAsText[i]);
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