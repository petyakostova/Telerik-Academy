/* 14. Hexadecimal to Decimal Number
   Using loops write a program that converts a hexadecimal integer number to its decimal form.
   The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.
   Input: The input will consists of a single line containing a single hexadecimal number as string.
   Output: The output should consist of a single line - the decimal representation of the number as string.
   Constraints: All numbers will be valid 64-bit integers.                                  */

using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexaNumber = Console.ReadLine();

        long decimalNumber = 0;

        for (int i = 0; i < hexaNumber.Length; i++)
        {
            int multiplier;

            switch (hexaNumber[hexaNumber.Length - i - 1])
            {
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default: multiplier = int.Parse(hexaNumber[hexaNumber.Length - i - 1].ToString()); break;
                //default: multiplier = (int)hexaNumber[hexaNumber.Length - i - 1] - 48; break;    // other way for default
            }

            decimalNumber += multiplier * (long)Math.Pow(16, i);
        }

        Console.WriteLine(decimalNumber);

    }
}