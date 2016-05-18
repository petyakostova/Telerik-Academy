/*  Problem 8. Binary short
    Write a program that shows the binary representation 
    of given 16-bit signed integer number N (the C# type short).
    Input: On the only line you will receive a decimal number - N
    Output: Print the its binary representation on a single line. There should be exactly 16 digits of output.
    Constraints: -215 <= N < 215
    Sample tests:
                    Input 	    Output
                    11 	        0000000000001011
                    -11 	    1111111111110101                       
                    -1          1111111111111111
                    500         0000000111110100
                    -56         1111111111001000    */

using System;

class ShortToBinaryConvertion
{
    static void Main()
    {
        short shortNumber = short.Parse(Console.ReadLine());

        Console.WriteLine(ShortToBinary(shortNumber));
    }

    private static string ShortToBinary(int number)
    {
        string binaryNumber = string.Empty;

        for (int i = 15; i >= 0; i--)
        {
            binaryNumber = ((number % 2) & 1) + binaryNumber;
            number >>= 1;
            //if (i % 4 == 0 && i != 0) binaryNumber = " " + binaryNumber;  // for better print
        }

        return binaryNumber;
    }
}