/* Problem 12. Extract Bit from Integer
    Write an expression that extracts from given integer n the value of given bit at index p.
Examples:
n 	    binary representation 	p 	bit @ p
5 	    00000000 00000101 	    2 	1
0 	    00000000 00000000 	    9 	0
15 	    00000000 00001111 	    1 	1
5343 	00010100 11011111 	    7 	1
62241 	11110011 00100001 	    11 	0                   */

using System;

class ExtractPBitFromIntegerN
{
    static void Main()
    {
        Console.WriteLine("Insert an integer number: ");
        int number = int.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("Insert an index (position) of the bit, which value you want to extract: ");
        int position = int.Parse(Console.ReadLine());
        while (position < 0)
        {
            Console.WriteLine("Incorrect position format. Please insert an integer index: position >= 0: ");
            position = int.Parse(Console.ReadLine());
        }
        int numberRightP = number >> position;
        int bit = numberRightP & 1;
        Console.WriteLine("The bit #{0} is: {1}", position, bit);
    }
}