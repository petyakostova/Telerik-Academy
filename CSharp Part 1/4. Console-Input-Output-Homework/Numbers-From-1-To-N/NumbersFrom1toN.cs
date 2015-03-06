/* Problem 8. Numbers from 1 to n
   Write a program that reads an integer number n from the console 
   and prints all the numbers in the interval [1..n], each on a single line.
   Note: You may need to use a for-loop.
Examples:
input 	output
3 	    1
	    2
	    3
5 	    1
	    2
	    3
	    4
	    5
1 	    1                               */

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer number n= ");
        while (!int.TryParse(Console.ReadLine(), out n))             // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct integer number: ");
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}