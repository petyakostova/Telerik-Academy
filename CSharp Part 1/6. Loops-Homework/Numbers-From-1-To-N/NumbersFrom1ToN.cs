/*  Problem 1. Numbers from 1 to N
    Write a program that enters from the console a positive integer n and 
    prints all the numbers from 1 to n, on a single line, separated by a space.
Examples:
    n 	    output
    3 	    1 2 3
    5 	    1 2 3 4 5           */

using System;

class NumbersFrom1ToN
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
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}