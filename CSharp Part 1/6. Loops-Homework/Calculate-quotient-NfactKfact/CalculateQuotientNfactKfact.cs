/*  Problem 6. Calculate N! / K!
    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
Examples:
    n 	k 	n! / k!
    5 	2 	60
    6 	5 	6
    8 	3 	6720                        */

using System;

class CalculateQuotientNfactKfact
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter an integer number n: 1 < n < 100   n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number k: 1 < k < {0}   k= ", n);
            int k = int.Parse(Console.ReadLine());
            if (1 < k && k < n && n < 100)
            {
                ulong result = 1;
                for (int i = k + 1; i <= n; i++)
                {
                    result *= (ulong)i;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}