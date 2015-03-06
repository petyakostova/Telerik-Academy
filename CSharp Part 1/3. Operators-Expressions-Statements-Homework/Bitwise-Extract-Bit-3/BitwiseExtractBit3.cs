/* Problem 11. Bitwise: Extract Bit #3
   Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
   The bits are counted from right to left, starting from bit #0.
   The result of the expression should be either 1 or 0.
Examples:
n 	    binary representation 	bit #3
5 	    00000000 00000101 	    0
0 	    00000000 00000000 	    0
15 	    00000000 00001111 	    1
5343 	00010100 11011111 	    1
62241 	11110011 00100001 	    0               */

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Insert an unsigned integer number: ");
        uint number = uint.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("The binary representation of the {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(16, '0'));
        uint numberRight3 = number >> 3;
        uint bit = numberRight3 & 1;
        Console.WriteLine("The bit #3 is: " + bit);
    }
}