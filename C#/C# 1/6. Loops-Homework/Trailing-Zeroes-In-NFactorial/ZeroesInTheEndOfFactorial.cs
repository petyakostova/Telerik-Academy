/* 16.* Trailing Zeroes in N!
   Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
   Your program should work well for very big numbers, e.g. N = 100000.
   On the only input line, you will receive a single integer - the number N
   Output a single number - the count of trailing zeroes for the N!
   Constraints: N will always be a valid positive integer number. */

// Note: by given big numbers like 100000 it takes time to calculating the answer, but it's correct

using System;
using System.Numerics;  // must be added in References; needed for BigInteger

class ZeroesInTheEndOfFactorial
{
    static void Main()
    {
        int number;
        Console.Write("Enter an integer number: ");
        while (!int.TryParse(Console.ReadLine(), out number))          // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter an integer number: ");
        }

        BigInteger factorial = 1;

        while (number > 0)
        {
            factorial *= number;
            number--;
        }

        int counterZeroes = 0;

        while (factorial % 10 == 0)
        {
            counterZeroes++;
            factorial /= 10;
        }

        Console.WriteLine(counterZeroes);
    }
}