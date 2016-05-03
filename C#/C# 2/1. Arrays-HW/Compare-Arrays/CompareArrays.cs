/*  Problem 2. Compare arrays
    Write a program that reads two integer arrays of size N from the console and compares them element by element.
 */

using System;

class CompareArrays
{
    static void Main()
    {
        // input
        int n = int.Parse(Console.ReadLine());    // the length of the arrays
        int[] array1 = new int[n];                // create the array1 of given size        
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());  // read the elements of the array1 in a for loop
        }
        int[] array2 = new int[n];                // create the array2 of given size
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());  // read the elements of the array2 in a for loop
        }

        // check
        bool equal = true;
        for (int i = 0; i < n; i++)
        {
            if (array1[i] != array2[i])
            {
                equal = false;
                break;
            }
        }

        // output
        if (equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

    }
}