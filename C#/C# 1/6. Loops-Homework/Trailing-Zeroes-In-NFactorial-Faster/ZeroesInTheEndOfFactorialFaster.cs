/* 16. Trailing Zeroes in N! => Faster
   Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
   Your program should work well for very big numbers, e.g. N = 100000.
   On the only input line, you will receive a single integer - the number N
   Output a single number - the count of trailing zeroes for the N!
   Constraints: N will always be a valid positive integer number. */

//Method: Count 5s in prime factors => the faster solution

using System;

class ZeroesInTheEndOfFactorialFaster
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int counterZeroes = 0;

        if (number == 5)
        {
            counterZeroes = 1;
        }

        for (int i = 5; number / i >= 1; i *= 5)
        {
            counterZeroes += number / i;
        }

        // other way
        //for (int power5 = 5; power5 <= number; power5 *= 5)
        //{
        //    counterZeroes += number / power5;
        //}

        Console.WriteLine(counterZeroes);
    }
}