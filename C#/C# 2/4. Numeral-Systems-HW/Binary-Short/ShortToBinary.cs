/*  Problem 8. Binary short
    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */
/*  Note: Examples for faster testing:
                       16-bit signed integer    binary
                       -1                       1111111111111111
                       500                      0000000111110100
                       -56                      1111111111001000 
 */

using System;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Enter an integer number in interval [{0}; {1}]: ", short.MinValue, short.MaxValue);
        short shortNumber = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinaryConvertion(shortNumber));
    }

    static string ShortToBinaryConvertion(int number)
    {
        string binaryNumber = string.Empty;

        for (int i = 15; i >= 0; i--)
        {
            binaryNumber = ((number % 2) & 1) + binaryNumber;
            number >>= 1;
            //if (i % 4 == 0) binary = " " + binary;    // for better print
        }
        return binaryNumber;
    }
}