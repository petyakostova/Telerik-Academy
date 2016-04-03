/* 8. Catalan Numbers
      In combinatorics, the Catalan numbers are calculated by the following formula: 
      https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png
      Write a program to calculate the Nth Catalan number by given N
      Constraints: N will always be a valid integer number in the range [0, 100]. Hint: overflow is possible. */

using System;
using System.Numerics;  //must be added in References; needed for BigInteger

class NthCatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 <= n && n <= 100)
        {
            BigInteger numerator = 1;

            for (int i = 1; i <= (2 * n); i++)
            {
                // (2*n)!
                numerator *= i; 
            }

            BigInteger denominator = 1;

            for (int i = 1; i <= (n + 1); i++)
            {
                // (n+1)!
                denominator *= i;
            }

            for (int i = 1; i <= n; i++)
            {
                // n!
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