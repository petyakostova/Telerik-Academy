/* 11. Binary to Decimal Number
   Using loops write a program that converts a binary integer number to its decimal form.
   The input is entered as string. The output should be a variable of type long.
   Do not use the built-in .NET functionality.
   Input: You will receive exactly one line containing an integer number representation in binary
   Output: On the only output line write the decimal representation of the number
   Constraints: All input numbers will be valid 32-bit integers                         */

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        //Console.Write("Enter a binary number (consisted of 0 and 1): ");
        string binaryNumber = Console.ReadLine();       

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '0')
            {
                // bypasses the iteration of the inner-most loop and jumps to the update expression in for loop
                continue;           
            }

            decimalNumber += (long)Math.Pow(2, i);
        }

        Console.WriteLine(decimalNumber);
    }
}