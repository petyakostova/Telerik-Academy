/* Problem 11. 3rd Bit
   Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console. The bits are counted from right to left, starting from bit 0. The result of the expression should be either 1 or 0. Print it on the console.
        My tests:
        n 	    binary representation 	bit #3
        15 	    00000000 00001111 	    1
        1024    0000010000000000        0
        5 	    00000000 00000101 	    0
        0 	    00000000 00000000 	    0
        5343 	00010100 11011111 	    1
        62241 	11110011 00100001 	    0              */

using System;

class Get3rdBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        //Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));

        uint numberRight3 = number >> 3;
        uint bit3 = numberRight3 & 1;
        Console.WriteLine(bit3); 
    }
}