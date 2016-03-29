/* Problem 12. Extract Bit from Integer
    Write a program that reads from the console two integer numbers P and N 
    and prints on the console the value of P's N-th bit.                                         
        |     Input      | Binary representation |     Output     |
        |----------------|-----------------------|----------------|
        |5<br/>2         |00000000 00000101      |1               |
        |0<br/>9         |00000000 00000000      |0               |
        |15<br/>1        |00000000 00001111      |1               |
        |5343<br/>7      |00010100 11011111      |1               |
        |62241<br/>11    |11110011 00100001      |0               |*/

using System;

class GetNthBit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());    
        int position = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));

        int numberRightP = number >> position;
        int bit = numberRightP & 1;
        Console.WriteLine(bit);
    }
}