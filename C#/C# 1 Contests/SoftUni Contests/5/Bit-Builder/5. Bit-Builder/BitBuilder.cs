// 70/100 in bgcoder

using System;

class BitBuilder
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }

            int position = int.Parse(input);

            string order = Console.ReadLine();

            switch (order)
            {
                case "flip":
                    num = FlipBit(num, position);
                    break;
                case "insert":
                    num = InsertBit(num, position);
                    break;
                case "remove":
                    num = RemoveBit(num, position);
                    break;
            }
        }

        Console.WriteLine(num);
    }

    static long RemoveBit(long number, int pos)
    {
        long result = 0;
        int addition = 0;

        for (int i = 0; i < 32; i++)
        {
            long mask = 1 << i;
            //long mask = number << i;

            if (i == pos)
            {
                addition = 1;
                continue;
            }

            result += (number & mask) >> addition;
        }

        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0')); //medium check
        return result;
    }

    static long InsertBit(long number, int pos)
    {
        long result = 0;
        int addition = 0;

        for (int i = 0; i < 32; i++)
        {
            long mask = 1 << i;
            //long mask = number << i;

            if (i == pos)
            {
                result += 1 << pos;
                addition = 1;
            }

            result += (number & mask) << addition;
        }

        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0')); //medium check
        return result;
    }

    static long FlipBit(long number, int pos)
    {
        long mask = 1 << pos;

        // get the bit at position pos from a number num - first way
        long bit = (number >> pos) & 1;
        // get the bit at position pos from a number num - second way
        //long bit = mask & number;

        if (bit == 1)
        {
            // set the bit at position pos to 0
            number = number & ~mask;
        }
        else
        {
            // set the bit at position pos to 1
            number = number | mask;
        }

        //Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0')); //medium check
        return number;
    }

}