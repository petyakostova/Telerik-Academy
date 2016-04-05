/* 11. Binary to Decimal Number
   Using loops write a program that converts a binary integer number to its decimal form.
   The input is entered as string. The output should be a variable of type long.
   Do not use the built-in .NET functionality.
   Input: You will receive exactly one line containing an integer number representation in binary
   Output: On the only output line write the decimal representation of the number
   Constraints: All input numbers will be valid 32-bit integers                         */

using System;

class BinaryToDecimal
{
    static void Main()
    {
        //Console.Write("Enter a binary number (consisted of 0 and 1): ");
        string binaryNumber = Console.ReadLine();

        //long numDec = Convert.ToInt64(binaryNumber, 2);
        //Console.WriteLine(numDec);   

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[binaryNumber.Length - i - 1] == '1')
            {
                decimalNumber += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decimalNumber);
    }
}