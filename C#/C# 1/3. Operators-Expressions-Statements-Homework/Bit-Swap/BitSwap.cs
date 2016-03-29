/* Problem 15. Bit Swap (Advanced Bit Exchange)
   Write a program first reads 4 numbers n, p, q and k and then swaps bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of n. Print the resulting integer on the console. On the only four lines of the input you will receive the integers n, p, q and k in this order (n will always be a valid 32-bit positive integer). Output a single value - the value of n after the bit swaps.

    |     Input                     |     Binary representation          |  Binary representation after swaps |   Output    |
    |-------------------------------|------------------------------------|------------------------------------|-------------|
    |1140867093<br/>3<br/>24<br/>3  |01000100 00000000 01000000 00010101 |01000010 00000000 01000000 00100101 |1107312677   |
    |4294901775<br/>24<br/>3<br/>3  |11111111 11111111 00000000 00001111 |11111001 11111111 00000000 00111111 |4194238527   |
    |2369124121<br/>2<br/>22<br/>10 |10001101 00110101 11110111 00011001 |01110001 10110101 11111000 11010001 |1907751121   |*/

using System;

class BitSwap
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());      
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: " + Convert.ToString((uint)number, 2).PadLeft(32, '0'));
        
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            uint[] pArray = new uint[k];
            uint[] qArray = new uint[k];
            uint result;
            for (int position = p; position < p + k; position++)//get the bits at position p, p+1, ..., p+k-1 and put them in pArray
            {
                uint numberRightP = ((uint)number) >> position;
                pArray[position - p] = numberRightP & 1;
            }
            for (int position = q; position < q + k; position++)//get the bits at position q, q+1, ..., q+k-1 and put them in qArray
            {
                uint numberRightP = ((uint)number) >> position;
                qArray[position - q] = numberRightP & 1;
            }
            for (int position = p; position < p + k; position++)   // exchange the bits at position p, p+1, ..., p+k-1
            {
                if (qArray[position - p] == 0)                  // to 0
                {
                    uint mask = (uint)(~(1 << position));
                    result = ((uint)number) & mask;
                }
                else                                           // to 1
                {
                    uint mask = (uint)(1 << position);
                    result = ((uint)number) | mask;
                }
                number = result;
            }
            for (int position = q; position < q + k; position++)    // exchange the bits at position q, q+1, ..., q+k-1
            {
                if (pArray[position - q] == 0)                   // to 0
                {
                    uint mask = (uint)(~(1 << position));
                    result = ((uint)number) & mask;
                }
                else                                              // to 1
                {
                    uint mask = (uint)(1 << position);
                    result = ((uint)number) | mask;
                }
                number = result;
            }

            Console.WriteLine("Binary representation after swaps: " + Convert.ToString(((uint)number), 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}