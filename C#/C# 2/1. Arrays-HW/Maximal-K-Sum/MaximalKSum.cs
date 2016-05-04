/*  Problem 6. Maximal K sum
    Write a program that reads two integer numbers N and K and an array of N elements from the console. 
    Find the maximal sum of K elements in the array.
 */

// Interpretation: It is not necessary the elements to be consecutively placed.

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter an integer number N: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number for N: ");
        }
        Console.Write("Enter an integer number K: ");

        int k;
        while (!int.TryParse(Console.ReadLine(), out k) || k > n)    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number for K: ");
        }

        int[] array = new int[n];
        Console.WriteLine("Enter {0} numbers to array:", n);
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.WriteLine("The {0} elements that have maximal sum are: ", k);
        for (int i = 0; i < k; i++)
        {
            Console.Write(i != k - 1 ? array[i] + ", " : array[i] + "\n");
        }
        
    }
}