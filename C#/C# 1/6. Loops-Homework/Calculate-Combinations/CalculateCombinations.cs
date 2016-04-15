/* 7. Calculate N! / (K! * (N-K)!)
   In combinatorics, the number of ways to choose N different members out of a group of N different elements 
   (also known as the number of combinations) is calculated by the following formula:  
    https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png 
    For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
    Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K. Try to use only two loops.
    Input: On the first line, there will be only one number - N. On the second line, there will also be only one number - K.
    On the only output line, write the result of the calculation for the provided N and K.
    Constraints: 1 < K < N < 100        Hint: overflow is possible                             */

using System;
using System.Numerics;  //must be added in References

class CalculateCombinaions
{
    static void Main()
    {
        //Console.Write("Enter an integer number n: 1 < n < 100   n= ");
        int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter an integer number k: 1 < k < {0}   k= ", n);
        int k = int.Parse(Console.ReadLine());
        if (1 < k && k < n && n < 100)
        {
            BigInteger result = 1;

            for (int i = k + 1; i <= n; i++)
            {
                result *= i;
            }

            for (int j = 1; j <= (n - k); j++)
            {
                result /= j;
            }

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}