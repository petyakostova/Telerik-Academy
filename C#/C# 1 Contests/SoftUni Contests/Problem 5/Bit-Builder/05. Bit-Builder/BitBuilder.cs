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
        return result;
    }

    static int FlipBit(int num, int pos)
    {
        int mask = 1 << pos;

        int bit = mask & num;

        if (bit == 1)
        {
            num = num & ~mask;
        }
        else
        {
            num = num | mask;
        }

        return num;
    }

}