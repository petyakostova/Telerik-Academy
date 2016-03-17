/*  Problem 6. Maximal K sum - Consecutive
    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
 */
// Interpretation: The elements are consecutively placed.

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

        // help values
        string maxSeq = "";
        int sum = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            string currentSeq = "";

            // out of the array bounds
            if (i + k > array.Length)
            {
                break;
            }

            // set current sum
            for (int j = i; j < i + k; j++)
            {
                sum += array[j];
                currentSeq = currentSeq + array[j] + ' ';
            }

            // max sum check
            if (sum > maxSum)
            {
                maxSeq = currentSeq;
                maxSum = sum;
            }

            sum = 0;
        }
        Console.WriteLine(maxSeq);
        Console.WriteLine(maxSum);

    }
}