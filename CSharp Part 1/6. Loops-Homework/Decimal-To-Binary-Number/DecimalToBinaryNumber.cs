/*  Problem 14. Decimal to Binary Number
    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
Examples:
decimal 	binary
0 	        0
3 	        11
43691 	    1010101010101011
236476736 	1110000110000101100101000000                        */

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long decimalNumber;
        Console.Write("Enter an integer number: ");
        while (!long.TryParse(Console.ReadLine(), out decimalNumber))   // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter an integer number: ");
        }
        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string binaryNumber = "";                                   // the same like: string binaryNumber = null;         
            while (decimalNumber > 0)
            {
                int remainder = (int)decimalNumber % 2;
                binaryNumber = remainder + binaryNumber;
                decimalNumber /= 2;
            }
            Console.WriteLine(binaryNumber);
        }
    }
}