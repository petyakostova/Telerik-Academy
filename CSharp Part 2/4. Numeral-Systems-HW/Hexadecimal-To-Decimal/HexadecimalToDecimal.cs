/*  Problem 4. Hexadecimal to decimal
    Write a program to convert hexadecimal numbers to their decimal representation.
 */
/*  Notes: Examples for faster testing:
                        hexadecimal 	decimal
                        FE 	            254
                        1AE3 	        6883
                        4ED528CBB4 	    338583669684 
 */
using System;

class HexadecimalToDecimal
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