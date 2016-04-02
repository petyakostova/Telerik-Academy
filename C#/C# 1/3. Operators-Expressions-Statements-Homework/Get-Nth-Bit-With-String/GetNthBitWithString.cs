/* 12. Extract Bit from Integer
    Write a program that reads from the console two integer numbers P and N 
    and prints on the console the value of P's N-th bit. 
    Constraints: **N** will be a positiv integer and always smaller than 55.
                 **P** will always be in the range `[0, 2<sup>55</sup>)`. 
                                                        
        |     Input      | Binary representation |     Output     |
        |----------------|-----------------------|----------------|
        |5<br/>2         |00000000 00000101      |1               |
        |0<br/>9         |00000000 00000000      |0               |
        |15<br/>1        |00000000 00001111      |1               |
        |5343<br/>7      |00010100 11011111      |1               |
        |62241<br/>11    |11110011 00100001      |0               |*/

using System;

class GetNthBitWithString
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

        int bitIndex = (binaryNum.Length - 1) - position;

        Console.WriteLine(binaryNum[bitIndex]);
    }
}