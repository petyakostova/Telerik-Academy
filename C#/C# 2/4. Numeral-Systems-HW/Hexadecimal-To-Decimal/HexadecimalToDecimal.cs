/*  4. Hexadecimal to decimal
    Write a program that converts a hexadecimal number N to its decimal representation.
    Input: On the only line you will receive a hexadecimal number - N. 
           There will not be leading zeros. Letters will be uppercase.
    Output: Print the decimal representation of N on a single line. There should not be leading zeros.
    Constraints: 1 <= N <= 1018 = DE0B6B3A7640000(16)
    Sample tests:
                    Input 	        Output
                    13 	            19
                    FE 	            254
                    1AE3 	        6883
                    4ED528CBB4 	    338583669684            */

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();

        Console.WriteLine(HexToDecimal(hexadecimalNumber));
    }

    private static long HexToDecimal(string hexNumber)
    {
        long decimalNumber = 0;

        for (int position = 0; position < hexNumber.Length; position++)
        {
            int multiplier;

            switch (hexNumber[hexNumber.Length - position - 1])
            {
                case 'A': multiplier = 10; break;
                case 'B': multiplier = 11; break;
                case 'C': multiplier = 12; break;
                case 'D': multiplier = 13; break;
                case 'E': multiplier = 14; break;
                case 'F': multiplier = 15; break;
                default: multiplier = int.Parse(hexNumber[hexNumber.Length - position - 1].ToString()); break;
                // other way
                //default: multiplier = (int)hexNumber[hexNumber.Length - position - 1] - 48; break; 
            }

            decimalNumber += multiplier * (long)Math.Pow(16, position);
        }

        return decimalNumber;
    }
}