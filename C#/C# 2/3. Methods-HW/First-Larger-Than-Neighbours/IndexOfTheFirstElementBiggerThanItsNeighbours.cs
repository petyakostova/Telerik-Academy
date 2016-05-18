/*  6. First larger than neighbours
    Write a method that returns the index of the first element in array that is larger than its neighbours, 
    or -1, if there is no such element.
    Input:
            On the first line you will receive the number N - the size of the array
            On the second line you will receive N numbers sepated by spaces - the array
    Output: Print the index of the first element that is larger than its neighbours or -1 if none are
    Constraints: 1 <= N <= 1024
    Sample tests:
    Input 	                    Output
    6
    -26 -25 -28 31 2 27 	    1           */

using System;

class IndexOfTheFirstElementBiggerThanItsNeighbours
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        ArrayInput(length, array);

        Console.WriteLine(FirstLargerThanNeighbours(length, array));
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

    static int FirstLargerThanNeighbours(int length, int[] array)
    {
        int index = -1;

        for (int i = 1; i < length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
                // other way
                //index = i;
                //break;
            }
        }

        return index;
    }

}