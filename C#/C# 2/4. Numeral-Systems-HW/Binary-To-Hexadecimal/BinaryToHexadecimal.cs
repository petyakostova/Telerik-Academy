/*  6. Binary to hexadecimal
    Write a program to convert binary numbers to hexadecimal numbers (directly).
    Input: On the only line you will receive a decimal number - N. There will not be leading zeros
    Output: Print the its binary representation on a single line.
            There should not be leading zeros. Use uppercase letters
    Constraints: 1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
    Sample tests:
                    Input                                           Output
                    10011 	                                        13
                    11111110                                        FE 	            
                    0001101011100011                                1AE3 	        
                    0100111011010101001010001100101110110100        4ED528CBB4      */

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        Console.WriteLine(BinaryToHex(binaryNumber));
    }

    private static string BinaryToHex(string binNumber)
    {
        StringBuilder binaryNum = new StringBuilder(binNumber);

        bool isNegative = false;

        if (binaryNum[0] == '-')
        {
            isNegative = true;
            binaryNum.Remove(0, 1);
        }

        // Padding leading zeros
        for (int i = 0, length = binaryNum.Length; i < (4 - length % 4) % 4; i++) 
        {
            binaryNum.Insert(0, '0');
        }

        StringBuilder hexNumber = new StringBuilder();

        StringBuilder word = new StringBuilder("0000");

        for (int fours = 0; fours < binaryNum.Length; fours += 4)
        {
            for (int pos = fours; pos < fours + 4; pos++)
            {
                word[pos % 4] = binaryNum[pos];
            }

            switch (word.ToString())
            {
                case "0000": hexNumber.Append('0'); break;
                case "0001": hexNumber.Append('1'); break;
                case "0010": hexNumber.Append('2'); break;
                case "0011": hexNumber.Append('3'); break;
                case "0100": hexNumber.Append('4'); break;
                case "0101": hexNumber.Append('5'); break;
                case "0110": hexNumber.Append('6'); break;
                case "0111": hexNumber.Append('7'); break;
                case "1000": hexNumber.Append('8'); break;
                case "1001": hexNumber.Append('9'); break;
                case "1010": hexNumber.Append('A'); break;
                case "1011": hexNumber.Append('B'); break;
                case "1100": hexNumber.Append('C'); break;
                case "1101": hexNumber.Append('D'); break;
                case "1110": hexNumber.Append('E'); break;
                case "1111": hexNumber.Append('F'); break;
            }
        }

        if (isNegative)
        {
            hexNumber.Insert(0, '-');
        }

        return hexNumber.ToString();
    }
}