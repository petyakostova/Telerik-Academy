/* 7. Sum of 5 Numbers
   Write a program that reads 5 integer numbers from the console and prints their sum. All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive. */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());
        int num5 = int.Parse(Console.ReadLine());

        int sum = num1 + num2 + num3 + num4 + num5;

        Console.WriteLine(sum);
    }
}