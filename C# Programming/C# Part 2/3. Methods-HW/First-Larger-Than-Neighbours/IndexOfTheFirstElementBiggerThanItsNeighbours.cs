/*  Problem 6. First larger than neighbours
    Write a method that returns the index of the first element in array 
    that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.
 */

using System;

class IndexOfTheFirstElementBiggerThanItsNeighbours
{
    static void Main()
    {
        int[] array = ArrayInput();

        for (int i = 1; i < array.Length - 1; i++)  // the first and the last elements do not satisfy the condition - no need to check
        {
            if (ElementCompararer(array, i) != -1)
            {
                return;
            }
        }

        Console.WriteLine("-1 (there’s no such element)");
    }

    public static int[] ArrayInput()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int ElementCompararer(int[] array, int elemPosition)
    {
        if ((array[elemPosition] > array[elemPosition - 1]) && (array[elemPosition] > array[elemPosition + 1]))
        {
            Console.WriteLine("\nThe index of the first element in the array\n that is larger than its neighbours is: {0}\n", elemPosition);
            return elemPosition;
        }
        else
        {
            return -1;
        }
    }
}