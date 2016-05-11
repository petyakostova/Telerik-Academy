/*  Problem 4. Binary search
    Write a program, that reads from the console an array of N integers and an integer K, 
    sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter an integer number for the length of the array N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter an integer number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n + 1];
        Console.WriteLine("Enter {0} numbers to array:", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        array[n] = k;

        // Binary search works only on sorted arrays.
        Array.Sort(array);

        /*BinarySearch() returns the index of the specified value in the specified array, if value is found. 
        If value is not found and value is less than one or more elements in array, a negative number 
        which is the bitwise complement of the index of the first element that is larger than value. 
        If value is not found and value is greater than any of the elements in array, a negative number 
        which is the bitwise complement of (the index of the last element plus 1).*/
        int indexK = Array.BinarySearch(array, k);

        //if (array[indexK] == array[indexK + 1])
        //{
        //    Console.WriteLine("\nThe largest number in the array which is <= {0} is: \n{1}", k, array[indexK]);
        //}
        //else 
        if (indexK == 0)
        {
            Console.WriteLine(
                "\nThere is no smaller or equal to K = {0} number in the array.\nAll the elements are larger than {0}.", k);
        }
        else
        {
            Console.WriteLine("\nThe largest number in the array which is <= {0} is: {1}", k, array[indexK - 1]);
        }

    }
}