/*  Problem 1. Decimal to binary
    Write a program to convert decimal numbers to their binary representation.
 */
/*  Notes: Examples for faster testing:
                        decimal 	binary
                        0 	        0
                        3 	        11
                        43691 	    1010101010101011
                        236476736 	1110000110000101100101000000  
 */
using System;

class DecimalToBinary
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
            string binaryNumber = "";                   // other way: string binaryNumber = null;         
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