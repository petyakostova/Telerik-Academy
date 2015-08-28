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
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[n + 1];
        Console.WriteLine("Enter {0} numbers to array:", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
                
        array[n] = K;

        // Binary search works only on sorted arrays.
        Array.Sort(array);

        int indexK = Array.BinarySearch(array, K);

        if (indexK == n)
        {
            Console.WriteLine("\nThe largest number in the array which is <= {0} is: \n{1}", K, array[n - 1]);
        }
        else if (array[indexK] == array[indexK + 1])
        {
            Console.WriteLine("\nThe largest number in the array which is <= {0} is: \n{1}", K, array[indexK]);
        }
        else if (indexK == 0)
        {
            Console.WriteLine(
                "\nThere is no smaller or equal to K = {0} number in the array.\nAll the elements are larger than {0}.", K);
        }
        else
        {
            Console.WriteLine(array[indexK - 1]);
        }      
        
    }
}