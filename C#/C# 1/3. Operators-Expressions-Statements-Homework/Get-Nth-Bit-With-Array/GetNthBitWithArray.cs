/* 12. Extract Bit from Integer
    Write a program that reads from the console two integer numbers P and N 
    and prints on the console the value of P's N-th bit. 
    Constraints: N will be a positive integer and always smaller than 55; 
                 0 <= P <= 2<sup>55</sup>
    Sample tests: 

                |     Input       | Binary representation      | Output |
                |-----------------|----------------------------|--------|
                | 5<br/>2         | 00000000 00000000 00000101 | 1      |
                | 0<br/>9         | 00000000 00000000 00000000 | 0      |
                | 15<br/>1        | 00000000 00000000 00001111 | 1      |
                | 5343<br/>7      | 00000000 00010100 11011111 | 1      |
                | 62241<br/>11    | 00000000 11110011 00100001 | 0      |
                | 985276<br/>49   | 00001111 00001000 10111100 | 0      |*/

using System;

class GetNthBitWithArray
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        string binaryNum = Convert.ToString(number, 2).PadLeft(64, '0');

        char[] arrNum = binaryNum.ToCharArray();

        int bitIndex = (arrNum.Length - 1) - position;

        Console.WriteLine(arrNum[bitIndex]);
    }
}