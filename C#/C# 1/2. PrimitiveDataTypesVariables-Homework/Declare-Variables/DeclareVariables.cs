//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. 
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        uint c = 4825932;
        byte d = 97;
        short f = -10000;
        Console.WriteLine("The five variables with the relevant types are:\nushort -> {0}\nsbyte -> {1}\nuint -> {2}\nbyte -> {3}\nshort -> {4}", a, b, c, d, f);
    }
}