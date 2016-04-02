/* 1. Numbers from 1 to N
   Write a program that enters from the console a positive integer n. N will be a valid positive 32-bit integer. 
   and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace. */

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}