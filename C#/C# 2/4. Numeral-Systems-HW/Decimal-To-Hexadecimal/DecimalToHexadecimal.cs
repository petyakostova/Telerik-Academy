/*  3. Decimal to hexadecimal
    Write a program that converts a decimal number N to its hexadecimal representation.
    Input: On the only line you will receive a decimal number - N. There will not be leading zeros
    Output: Print the hexadecimal representation of N on a single line. There should not be leading zeros.
            Use uppercase letters.
    Constraints: 1 <= N <= 1018
    Sample tests:
                    Input 	        Output
                    19 	            13                
                    254 	        FE
                    6883 	        1AE3
                    338583669684 	4ED528CBB4              */

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        Console.WriteLine(DecimalToHex(decimalNumber));
    }

    static string DecimalToHex(long decNumber)
    {
        if (decNumber == 0)
        {
            return "0";
        }
        else
        {
            string hexadecimalNumber = string.Empty; // other way: string hexaNumber = "";   
                  
            while (decNumber > 0)
            {
                // must be long; when this type is int the result is wrong
                long checkRemainder = (long)decNumber % 16; 

                string remainder = string.Empty;

                switch (checkRemainder)
                {
                    case 10: remainder = "A"; break;
                    case 11: remainder = "B"; break;
                    case 12: remainder = "C"; break;
                    case 13: remainder = "D"; break;
                    case 14: remainder = "E"; break;
                    case 15: remainder = "F"; break;
                    default: remainder = checkRemainder.ToString(); break;
                }

                hexadecimalNumber = remainder + hexadecimalNumber;
                decNumber /= 16;
            }

            return hexadecimalNumber;
        }
    }

}