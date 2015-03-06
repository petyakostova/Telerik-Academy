/*  Problem 5. Larger than neighbours
    Write a method that checks if the element at given position in given array of integers 
    is larger than its two neighbours (when such exist).
 */

using System;

class ElementIsBiggerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        int[] array = new int[length];
        ArrayInput(length, array);

        Console.Write("Enter the position of the element - from [1 to {0}]: ", length);   // the positions start from 1
        int elemPosition = int.Parse(Console.ReadLine());

        ElementCompararer(length, array, elemPosition);
    }

    static void ArrayInput(int length, int[] array)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine()); 
        }
    }

    static void ElementCompararer(int length, int[] array, int elemPosition)
    {
        if ((elemPosition == 1) || (elemPosition == length))
        {
            Console.WriteLine("The element on position {0} doesn't have two neighbours.", elemPosition);
        }
        else
        {
            if ((array[elemPosition - 1] > array[elemPosition]) && (array[elemPosition - 1] > array[elemPosition - 2]))
            {
                Console.WriteLine("The element on position {0} is {1}\n and it is bigger than it's two neighbours ({2} and {3}).", elemPosition, array[elemPosition - 1], array[elemPosition - 2], array[elemPosition]);
            }
            else
            {
                Console.WriteLine("The element on position {0} is {1}\n and it is NOT bigger than it's two neighbours ({2} and {3}).", elemPosition, array[elemPosition - 1], array[elemPosition - 2], array[elemPosition]);
            }
        }
    }
}