/* 6. Calculate N! / K!
   Write a program that calculates N! / K! for given N and K.
   Use only one loop.
   Input: On the first line, there will be only one number - N. On the second line, there will be only one number - K.
   Output a single line, consisting of the result from the calculation described above.
   Constraints: 1 < K < N < 100. N and K will always be valid integer numbers. Hint: overflow is possible.  */

using System;
using System.Numerics; //must be added in References

class CalculateQuotientNfactKfact
{
    static void Main()
    {
        //Console.Write("Enter an integer number n: 1 < n < 100   n= ");
        int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter an integer number k: 1 < k < {0}   k= ", n);
        int k = int.Parse(Console.ReadLine());

        //if (1 < k && k < n && n < 100)
        //{
            BigInteger result = 1;

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input!");
        //}
    }
}