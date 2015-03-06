/* Problem 18.* Trailing Zeroes in N!
   Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
   Your program should work well for very big numbers, e.g. n=100000.
Examples:
n 	    trailing zeroes of n! 	explaination
10 	    2 	                    3628800
20 	    4 	                    2432902008176640000
100000 	24999 	                think why 
 */

// Note: by given big numbers like 100000 it takes time to calculating the answer, but it's correct

using System;
using System.Numerics;                                                  // must be added in References; needed for BigInteger

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