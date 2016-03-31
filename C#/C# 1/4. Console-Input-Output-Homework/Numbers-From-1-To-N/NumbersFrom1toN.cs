/* 8. Numbers from 1 to n
   Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line. 1 <= N < 1000. N will always be a valid integer number. */

using System;

class NumbersFrom1toN
{
    static void Main()
    {
        Console.BufferHeight = 1001;

        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}