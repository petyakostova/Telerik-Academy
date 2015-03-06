/*  Problem 2. Numbers Not Divisible by 3 and 7
    Write a program that enters from the console a positive integer n and 
    prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
Examples:
    n 	    output
    3 	    1 2
    10 	    1 2 4 5 8 10                */

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        int n;
        Console.Write("Enter a positive integer number n = ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)   // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter a positive integer number n= ");
        }
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}