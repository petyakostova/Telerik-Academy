/* Problem 13. Check a Bit at Given Position
   Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
   in given integer number n, has value of 1.
Examples:
n 	    binary representation of n 	    p 	    bit @ p == 1
5 	    00000000 00000101 	            2 	    true
0 	    00000000 00000000 	            9 	    false
15 	    00000000 00001111 	            1 	    true
5343 	00010100 11011111 	            7 	    true
62241 	11110011 00100001 	            11 	    false                   */

using System;

class CheckIfPBitIs1
{
    static void Main()
    {
        Console.WriteLine("Insert an integer number: ");
        int number = int.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("Insert an index (position) of the bit, which value you want to check: ");
        int position = int.Parse(Console.ReadLine());
        while (position < 0)
        {
            Console.WriteLine("Incorrect position format. Please insert an integer index: position >= 0: ");
            position = int.Parse(Console.ReadLine());
        }
        int numberRightP = number >> position;
        int bit = numberRightP & 1;
        Console.WriteLine((bit == 1) ? "true" : "false");
    }
}