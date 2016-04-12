using System;

class BitBuilder
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

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

    static int RemoveBit(int number, int pos)
    {
        int result = 0;
        int addition = 0;

        for (int i = 0; i < 32; i++)
        {
            int mask = 1 << i;

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

    static int InsertBit(int number, int pos)
    {
        int result = 0;
        int addition = 0;

        for (int i = 0; i < 32; i++)
        {
            int mask = 1 << i;

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

    static int FlipBit(int num, int pos)
    {
        // get the bit at position pos from a number num
        int bit = (num >> pos) & 1;

        int mask = 1 << pos;
        if (bit == 1)
        {
            // set the bit at position pos to 0
            num = num & ~mask;
        }
        else
        {
            // set the bit at position pos to 1
            num = num | mask;
        }

        //Console.WriteLine(Convert.ToString(num, 2).PadLeft(16, '0')); //medium check
        return num;
    }

}