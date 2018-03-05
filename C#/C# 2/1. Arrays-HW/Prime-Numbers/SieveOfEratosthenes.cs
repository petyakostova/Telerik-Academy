/*  Problem 15. Prime numbers
    Write a program that finds all prime numbers in the range [1 ... N]. 
    Use the Sieve of Eratosthenes algorithm. 
    The program should print the biggest prime number which is <= N.
    Input: On the first line you will receive the number N
    Output: Print the biggest prime number which is <= N
    Constraints: 2 <= N <= 10 000 000
 */

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1]; // False by default
        
        // Find all prime numbers in the range [1...n]
        for (int i = 2; i <= Math.Sqrt(n); i++) //n + 1 = primes.Length
        {
            // Skip those numbers that are not prime
            if (primes[i] == false)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        for (int i = n; i >= 2; i--)
        {
            if (!primes[i])
            {
                Console.WriteLine(i);
                break;
            }
        }

        //Print all prime numbers in the range[1...n]
        //for (int i = 2; i <= n; i++)
        //{
        //    // the numbers remaining not marked in the list are all the primes below n
        //    if (!primes[i])
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
    }
}