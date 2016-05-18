/*  1. Decimal to binary
    Write a program that converts a decimal number N to its binary representation.
    Input: On the only line you will receive a decimal number - N. There will not be leading zeros.
    Output: Print the binary representation of N on a single line. There should not be leading zeros.
    Constraints: 1 <= N <= 1018
    Sample tests
                    Input(decimal) 	    Output(binary)
                    19 	                10011                */

using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToBinaryNumber(decimalNumber));        
    }

    static string DecimalToBinaryNumber(long decNumber)
    {
        if (decNumber == 0)
        {
            return "0";
        }
        else
        {
            string binaryNumber = string.Empty; // other way: string binaryNumber = "";

            while (decNumber > 0)
            {
                binaryNumber = (decNumber % 2) + binaryNumber;
                decNumber /= 2;
            }

            return binaryNumber;            
        }
    }

}