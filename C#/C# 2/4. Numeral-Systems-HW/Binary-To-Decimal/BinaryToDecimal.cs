/*  2. Binary to decimal
    Write a program that converts a binary number N to its decimal representation.
    Input: On the only line you will receive a binary number - N. There will not be leading zeros
    Output: Print the decimal representation of N on a single line. There should not be leading zeros
    Constraints: 1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
    Sample tests:
                    Input 	    Output
                    10011 	    19                          */

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToDecimalNumber(binaryNumber));
    }

    static long BinaryToDecimalNumber(string binNumber)
    {
        long decimalNumber = 0;

        for (int position = 0; position < binNumber.Length; position++)
        {
            if (binNumber[binNumber.Length - position - 1] == '0')
            {
                // bypasses the iteration of the inner-most loop and jumps to the update expression in for loop
                continue;   
            }

            decimalNumber += (long)Math.Pow(2, position);
        }

        return decimalNumber;
    }
}