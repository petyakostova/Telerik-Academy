/* Problem 16.** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.
Examples:
n 	            p 	q 	k 	binary representation of n 	                    binary result 	                        result
1140867093 	    3 	24 	3 	01000100 00000000 01000000 00010101 	        01000010 00000000 01000000 00100101 	1107312677
4294901775 	    24 	3 	3 	11111111 11111111 00000000 00001111 	        11111001 11111111 00000000 00111111 	4194238527
2369124121 	    2 	22 	10 	10001101 00110101 11110111 00011001 	        01110001 10110101 11111000 11010001 	1907751121
987654321 	    2 	8 	11 	00111010 11011110 01101000 10110001 	        - 	                                    overlapping
123456789 	    26 	0 	7 	00000111 01011011 11001101 00010101 	        - 	                                    out of range
33333333333 	-1 	0 	33 	00000111 11000010 11010010 01001101 01010101 	- 	                                    out of range
*/

using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Insert an unsighned integer number: ");
        ulong number = ulong.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        Console.WriteLine("Binary representation of the number before the exchange: \n" + Convert.ToString((uint)number, 2).PadLeft(32, '0') + "\n");
        Console.Write("Enter p= ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q= ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k= ");
        int k = int.Parse(Console.ReadLine());
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
            Console.WriteLine("The binary result after the axchange is: \n" + Convert.ToString(((uint)number), 2).PadLeft(32, '0') + "\n");
            Console.WriteLine("The result is: " + number + "\n");
        }
    }
}