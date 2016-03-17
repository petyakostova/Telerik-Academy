/*  Problem 2. Binary to decimal
    Write a program to convert binary numbers to their decimal representation.
 */
/*  Notes: Examples for faster testing:
                        binary 	                        decimal
                        0 	                            0
                        11 	                            3
                        1010101010101011 	            43691
                        1110000110000101100101000000 	236476736   
 */
using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number (consisted of 0 and 1): ");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                continue;   // bypasses the iteration of the inner-most loop and jumps to the update expression in for loop
            }
            decimalNumber += (long)Math.Pow(2, i);
        }

        Console.WriteLine(decimalNumber);
    }
}