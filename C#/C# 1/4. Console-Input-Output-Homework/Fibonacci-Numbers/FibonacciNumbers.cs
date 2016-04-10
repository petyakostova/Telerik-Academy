/* 10. Fibonacci Numbers
   Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence 
   (at a single line, separated by comma and space - ", ") : 
   0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
   Constraints: 1 <= N <= 50. N will always be a valid positive integer number. */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.Write("0"); // prints the first member of the Fibonacci sequence
        }

        if (n > 1)
        {
            Console.Write(", 1"); // prints the second member of the Fibonacci sequence    
        }

        if (n > 2)
        {
            long memberN = 0;
            long memberNplus1 = 1;
            for (int i = 3; i <= n; i++)
            {
                long memberNplus2 = memberN + memberNplus1;
                Console.Write(", {0}", memberNplus2); // prints the i-member of the Fibonacci sequence
                memberN = memberNplus1;
                memberNplus1 = memberNplus2;
            }
        }
    }
}