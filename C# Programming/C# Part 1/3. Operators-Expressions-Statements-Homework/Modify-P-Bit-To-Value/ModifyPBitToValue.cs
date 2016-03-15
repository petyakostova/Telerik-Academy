/* Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
Examples:
n 	    binary representation of n 	    p 	    v 	    binary result 	    result
5 	    00000000 00000101 	            2 	    0 	    00000000 00000001 	1
0 	    00000000 00000000 	            9 	    1 	    00000010 00000000 	512
15 	    00000000 00001111 	            1 	    1 	    00000000 00001111 	15
5343 	00010100 11011111 	            7 	    0 	    00010100 01011111 	5215
62241 	11110011 00100001 	            11 	    0 	    11110011 00100001 	62241           */

using System;

class ModifyPBitToValue
{
    static void Main()
    {
        Console.WriteLine("Insert an integer number: ");
        int number = int.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("Insert an index (position) of the bit, which value you want to modify: ");
        int position = int.Parse(Console.ReadLine());
        while (position < 0)
        {
            Console.WriteLine("Incorrect position format. Please insert an integer index: position >= 0: ");
            position = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Insert a value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        while ((value != 0) && (value != 1))
        {
            Console.WriteLine("Incorrect value. Please insert a value 0 or 1: ");
            value = int.Parse(Console.ReadLine());
        }
        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine("The binary result is: " + Convert.ToString(result, 2).PadLeft(16, '0'));      // print the binary number
            Console.WriteLine("The result is: " + result + "\n");            
        }
        else
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine("The binary result is: " + Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("The result is: " + result + "\n");            
        }
    }
}