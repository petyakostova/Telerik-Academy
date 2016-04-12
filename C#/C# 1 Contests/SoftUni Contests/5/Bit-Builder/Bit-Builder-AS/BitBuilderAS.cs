// Author's Solution

using System;

class BitBuilderAS
{
    static int bitCount = 0;

    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        while (true)
        {
            string input = Console.ReadLine();

            int position;

            countBits(number);

            if (input != "quit")
            {
                position = int.Parse(input);
            }
            else
            {
                break;
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "flip":
                    number ^= (long)1 << position;
                    break;
                case "remove":
                    number = removeBit(position, number);
                    break;
                case "insert":
                    number = insertBit(position, number);
                    break;
            }
        }

        Console.WriteLine(number);
    }

    private static long removeBit(int position, long number)
    {
        long currentNumber = 0;
        bool changeOccured = false;

        for (int bit = 0; bit < bitCount; bit++)
        {
            long currentBit = (number >> bit) & 1;

            if (bit != position)
            {
                currentNumber >>= 1;
                currentNumber |= currentBit << (bitCount - 1);
            }
            else
            {
                changeOccured = true;
            }
        }

        if (changeOccured)
        {
            currentNumber >>= 1;
        }
        return currentNumber;
    }

    private static long insertBit(int position, long number)
    {
        long currentNum = 0;
        bool changeOccured = false;

        for (int bit = 0; bit < bitCount; bit++)
        {
            currentNum >>= 1;

            if (bit == position)
            {
                currentNum |= (long)1 << bitCount;
                bit--;
                position = -1;
                changeOccured = true;
            }
            else
            {
                long currentBit = (number >> bit) & 1;
                currentNum |= currentBit << bitCount;
            }
        }

        if (!changeOccured)
        {
            currentNum >>= 1;
            currentNum |= (long)1 << position;
        }

        return currentNum;
    }

    private static void countBits(long number)
    {
        long numToCount = number;
        bitCount = 0;

        while (numToCount > 0)
        {
            bitCount++;
            numToCount >>= 1;
        }
    }
}