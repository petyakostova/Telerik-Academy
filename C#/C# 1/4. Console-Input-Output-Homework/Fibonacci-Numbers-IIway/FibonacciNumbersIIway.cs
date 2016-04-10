/* 10. Fibonacci Numbers II way
   Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence 
   (at a single line, separated by comma and space - ", ") : 
   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
   Constraints: 1 <= N <= 50. N will always be a valid positive integer number. */

using System;

class FibonacciNumbersIIway
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long current;
        long previous = 1;
        long beforePrevious = 0;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                current = beforePrevious;
            }
            else if (i == 1)
            {
                current = previous;
            }
            else
            {
                current = beforePrevious + previous;
                beforePrevious = previous;
                previous = current;
            }

            if (i < n - 1)
            {
                Console.Write("{0}, ", current);
            }
            else
            {
                Console.Write(current);
            }

        }
    }
}