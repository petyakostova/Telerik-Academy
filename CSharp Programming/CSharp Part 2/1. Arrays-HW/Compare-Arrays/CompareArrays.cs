/*  Problem 2. Compare arrays
    Write a program that reads two integer arrays from the console and compares them element by element.
 */

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the length of the first array:");
        int length1 = int.Parse(Console.ReadLine());    // read from the console the length of the array1
        int[] array1 = new int[length1];                // create the array1 of given size
        Console.WriteLine("Please enter the elements of the first array: ");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array1[i] = int.Parse(Console.ReadLine());  // read the elements of the array1 in a for loop
            Console.WriteLine();
        }

        Console.WriteLine("Please enter the length of the second array:");
        int length2 = int.Parse(Console.ReadLine());    // read from the console the length of the array2
        int[] array2 = new int[length2];                // create the array2 of given size
        Console.WriteLine("Please enter the elements of the first array: ");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write("element[{0}] = ", i);
            array2[i] = int.Parse(Console.ReadLine());  // read the elements of the array2 in a for loop
            Console.WriteLine();
        }

        if (length1 != length2)
        {
            Console.WriteLine("The arrays have a different value for the length.");
        }
        else
        {
            bool equal = true;
            for (int i = 0; i < length1; i++)
            {
                if (array1[i] != array2[i])
                {
                    equal = false;
                    break;
                }
            }
            if (equal)
            {
                Console.WriteLine("The elements of the arrays are equal.");
            }
            else
            {
                Console.WriteLine("The elements of the arrays are not equal.");
            }
        }
    }
}