/*  Problem 8. Catalan Numbers
    In combinatorics, the Catalan numbers are calculated by the following formula: 
    https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png
    Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
Examples:
n 	        Catalan(n)
0 	        1
5 	        42
10 	        16796
15 	        9694845                                 */

using System;
using System.Numerics;                              // must be added in References; needed for BigInteger

class NthCatalanNumbers
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer number n: 1 <= n <= 100   n= ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 100)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter an integer number n: 1 <= n <= 100   n= ");
        }
        if (1 <= n && n <= 100)
        {
            BigInteger numerator = 1;
            for (int i = 1; i <= (2 * n); i++)
            {
                numerator *= i;
            }
            BigInteger denominator = 1;
            for (int i = 1; i <= (n + 1); i++)
            {
                denominator *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                denominator *= i;
            }
            Console.WriteLine(numerator / denominator);
        }
        else            // n == 0
        {
            Console.WriteLine(1);
        }
    }
}