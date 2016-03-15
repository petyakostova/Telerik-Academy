/* Problem 10. Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:
n 	    comments
1 	    0
3 	    0 1 1
10 	    0 1 1 2 3 5 8 13 21 34
*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number n= ");
        while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))      // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number n= ");
        }
        Console.Write("0 ");                                               // prints the first member of the Fibonacci sequence
        if (n != 1)
        {
            Console.Write("1 ");                                           // prints the second member of the Fibonacci sequence    
        }
        if (n > 2)
        {
            int memberN = 0;
            int memberNplus1 = 1;
            for (int i = 3; i <= n; i++)
            {
                int memberNplus2 = memberN + memberNplus1;
                Console.Write("{0} ", memberNplus2);                        // prints the i-member of the Fibonacci sequence
                memberN = memberNplus1;
                memberNplus1 = memberNplus2;
            }
        }
        Console.WriteLine(Environment.NewLine);
    }
}