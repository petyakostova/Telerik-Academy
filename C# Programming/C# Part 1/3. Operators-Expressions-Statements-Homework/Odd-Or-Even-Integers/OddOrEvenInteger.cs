/*Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
Examples:
n 	Odd?
3 	true
2 	false
-2 	false
-1 	true
0 	false           */

using System;

class OddOrEvenInteger
{
    static void Main()
    {
        Console.WriteLine("Insert a number of type Integer: ");
        int intNumber = int.Parse(Console.ReadLine());/* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                       * The operation of converting a string into another type is called parsing.*/
        Console.WriteLine((intNumber % 2 == 0) ? "The number {0} is even." : "The number {0} is odd.", intNumber);  
        
        Console.Write("The statement 'The number {0} is odd' is: ", intNumber);
        bool odd = (intNumber % 2 != 0);
        Console.WriteLine("{0} \n", odd);
    }
}