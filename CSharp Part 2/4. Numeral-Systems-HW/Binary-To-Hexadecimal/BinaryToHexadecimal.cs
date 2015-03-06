/*  Problem 6. Binary to hexadecimal
    Write a program to convert binary numbers to hexadecimal numbers (directly).
 */
/*  Notes: Examples for faster testing:
                    binary                                         hexadecimal
                    11111110                                       FE 	            
                    0001101011100011                               1AE3 	        
                    0100111011010101001010001100101110110100       4ED528CBB4      
 */

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a binary number (consisted of 0 and 1): ");
        string binaryNumber = Console.ReadLine();
        StringBuilder binary = new StringBuilder(binaryNumber);

        bool isNegative = false;
        if (binary[0] == '-')
        {
            isNegative = true;
            binary.Remove(0, 1);
        }

        for (int i = 0, length = binary.Length; i < (4 - length % 4) % 4; i++) //padding leading zeros
        {
            binary.Insert(0, '0');
        }

        StringBuilder hexaNumber = new StringBuilder();
        StringBuilder word = new StringBuilder("0000");

        for (int i = 0; i < binary.Length; i += 4)
        {
            for (int j = i; j < i + 4; j++)
            {
                word[j % 4] = binary[j];
            }

            switch (word.ToString())
            {
                case "0000": hexaNumber.Append('0'); break;
                case "0001": hexaNumber.Append('1'); break;
                case "0010": hexaNumber.Append('2'); break;
                case "0011": hexaNumber.Append('3'); break;
                case "0100": hexaNumber.Append('4'); break;
                case "0101": hexaNumber.Append('5'); break;
                case "0110": hexaNumber.Append('6'); break;
                case "0111": hexaNumber.Append('7'); break;
                case "1000": hexaNumber.Append('8'); break;
                case "1001": hexaNumber.Append('9'); break;
                case "1010": hexaNumber.Append('A'); break;
                case "1011": hexaNumber.Append('B'); break;
                case "1100": hexaNumber.Append('C'); break;
                case "1101": hexaNumber.Append('D'); break;
                case "1110": hexaNumber.Append('E'); break;
                case "1111": hexaNumber.Append('F'); break;
                default: Console.WriteLine("Invalid number"); break;
            }
        }

        if (isNegative)
        {
            hexaNumber.Insert(0, '-');
        }

        Console.WriteLine(hexaNumber.ToString());

    }
}