/* Problem 15.* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
Examples:
n 	        binary representation of n 	            binary result 	                        result
1140867093 	01000100 00000000 01000000 00010101 	01000010 00000000 01000000 00100101 	1107312677
255406592 	00001111 00111001 00110010 00000000 	00001000 00111001 00110010 00111000 	137966136
4294901775 	11111111 11111111 00000000 00001111 	11111001 11111111 00000000 00111111 	4194238527
5351 	    00000000 00000000 00010100 11100111 	00000100 00000000 00010100 11000111 	67114183
2369124121 	10001101 00110101 11110111 00011001 	10001011 00110101 11110111 00101001 	2335569705
*/

using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Insert an unsighned integer number: ");
        uint number = uint.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("Binary representation of the number before the exchange: \n" + Convert.ToString(number, 2).PadLeft(32, '0') + "\n");
        uint[] pArray = new uint[3];
        uint[] qArray = new uint[3];
        uint result;
        for (int position = 3; position < 6; position++)    // get the bits at position 3, 4 and 5 and put them in pArray
        {
            uint numberRightP = number >> position;
            pArray[position - 3] = numberRightP & 1;
        }
        for (int position = 24; position < 27; position++)  // get the bits at position 24, 25 and 26 and put them in qArray
        {
            uint numberRightP = number >> position;
            qArray[position - 24] = numberRightP & 1;
        }
        for (int position = 3; position < 6; position++)    // exchange the bits at position 3, 4 and 5
        {
            if (qArray[position - 3] == 0)                  // to 0
            {
                uint mask = (uint)(~(1 << position));
                result = number & mask;
            }
            else                                           // to 1
            {
                uint mask = (uint)(1 << position);
                result = number | mask;
            }
            number = result;
        }
        for (int position = 24; position < 27; position++)    // exchange the bits at position 24, 25 and 26
        {
            if (pArray[position - 24] == 0)                   // to 0
            {
                uint mask = (uint)(~(1 << position));
                result = number & mask;
            }
            else                                              // to 1
            {
                uint mask = (uint)(1 << position);
                result = number | mask;
            }
            number = result;
        }
        Console.WriteLine("The binary result after the axchange is: \n" + Convert.ToString(number, 2).PadLeft(32, '0') + "\n");
        Console.WriteLine("The result is: " + number + "\n");
    }
}