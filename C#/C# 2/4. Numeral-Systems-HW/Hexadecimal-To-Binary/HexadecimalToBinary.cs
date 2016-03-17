/*  Problem 5. Hexadecimal to binary
    Write a program to convert hexadecimal numbers to binary numbers (directly).
 */
/*  Notes: Examples for faster testing:
                        hexadecimal 	binary
                        FE 	            11111110
                        1AE3 	        0001101011100011
                        4ED528CBB4      0100111011010101001010001100101110110100
 */

using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexaNumber = Console.ReadLine();

        StringBuilder binaryNumber = new StringBuilder();

        foreach (char hexDigit in hexaNumber)
        {
            switch (hexDigit)
            {
                case '0': binaryNumber.Append("0000"); break;
                case '1': binaryNumber.Append("0001"); break;
                case '2': binaryNumber.Append("0010"); break;
                case '3': binaryNumber.Append("0011"); break;
                case '4': binaryNumber.Append("0100"); break;
                case '5': binaryNumber.Append("0101"); break;
                case '6': binaryNumber.Append("0110"); break;
                case '7': binaryNumber.Append("0111"); break;
                case '8': binaryNumber.Append("1000"); break;
                case '9': binaryNumber.Append("1001"); break;
                case 'A': binaryNumber.Append("1010"); break;
                case 'B': binaryNumber.Append("1011"); break;
                case 'C': binaryNumber.Append("1100"); break;
                case 'D': binaryNumber.Append("1101"); break;
                case 'E': binaryNumber.Append("1110"); break;
                case 'F': binaryNumber.Append("1111"); break;
                default: Console.WriteLine("Invalid hexadecimal number!"); break;
            }
        }
        Console.WriteLine(binaryNumber);
    }
}