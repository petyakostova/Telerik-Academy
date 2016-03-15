/*  Problem 9. Matrix of Numbers
    Write a program that reads from the console a positive integer number n (1 = n = 20) 
    and prints a matrix like in the examples below. Use two nested loops.
Examples:
n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7                         */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer number in range [1..20]   n = ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 20)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter a positive integer number in range [1..20]  n= ");
        }
        for (int row = 1; row <= n; row++)
        {
            for (int num = row; num <= (row + n - 1); num++)    // num < row + n
            {
                Console.Write("{0, 3}", num);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}