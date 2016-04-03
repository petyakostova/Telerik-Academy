/* 12. Decimal to Binary Number
   Using loops write a program that converts an integer number to its binary representation.
   The input is entered as long. The output should be a variable of type string.
   Do not use the built-in .NET functionality.
   Input: On the only input line you will receive the decimal integer number.
   Output a single string - the representation of the input decimal number in it's binary representation.
   Constraints: All numbers will always be valid 32-bit integers.                     */

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string binaryNumber = ""; // the same like: string binaryNumber = null;         

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