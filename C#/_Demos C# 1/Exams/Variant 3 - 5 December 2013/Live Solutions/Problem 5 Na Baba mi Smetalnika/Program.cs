using System;

class Program
{
    static void Main()
    {
        // read input
        int width = int.Parse(Console.ReadLine());

        long[] smetalo = new long[8];
        for (int i = 0; i < 8; i++)
        {
            smetalo[i] = int.Parse(Console.ReadLine());
        }

        // logic
        string command;
        bool stop = false;
        while (!stop)
        {
            command = Console.ReadLine();
            int row, col;
            long bits, newBits;
            int bitCount = 0;
            long mask = 1;

            switch (command)
            {
                case "right":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());

                    if (col < 0)
                        col = 0;

                    for (int i = 0; i < col; i++)
                    {
                        mask |= (1 << i);
                    }

                    bits = smetalo[row] & mask;
                    smetalo[row] &= ~mask;

                    bitCount = 0;
                    while (bits > 0)
                    {
                        bitCount += (int)(bits & 1);
                        bits >>= 1;
                    }

                    newBits = 1;
                    for (int i = 0; i < bitCount; i++)
                    {
                        newBits *= 2;
                    }
                    newBits -= 1;

                    smetalo[row] |= newBits;
                    break;
                case "left":
                    row = int.Parse(Console.ReadLine());
                    col = int.Parse(Console.ReadLine());

                    if (col < 0)
                        col = 0;

                    for (int i = 0; i < col; i++)
                    {
                        mask |= (1 << i);
                    }
                    mask <<= Math.Max(0, width - 1 - col);

                    bits = smetalo[row] & mask;
                    smetalo[row] &= ~mask;

                    bitCount = 0;
                    while (bits > 0)
                    {
                        bitCount += (int)(bits & 1);
                        bits >>= 1;
                    }

                    newBits = 1;
                    for (int i = 0; i < bitCount; i++)
                    {
                        newBits *= 2;
                    }
                    newBits -= 1;
                    newBits <<= (width - bitCount);

                    smetalo[row] |= newBits;
                    break;
                case "reset":
                    col = width - 1;
                    for (row = 0; row < 8; row++)
                    {
                        for (int i = 0; i < col; i++)
                        {
                            mask |= (1 << i);
                        }

                        bits = smetalo[row] & mask;
                        smetalo[row] &= ~mask;

                        bitCount = 0;
                        while (bits > 0)
                        {
                            bitCount += (int)(bits & 1);
                            bits >>= 1;
                        }

                        newBits = 1;
                        for (int i = 0; i < bitCount; i++)
                        {
                            newBits *= 2;
                        }
                        newBits -= 1;
                        newBits <<= (width - bitCount);

                        smetalo[row] |= newBits;
                    }
                    break;
                case "stop":
                    stop = true;
                    break;
            }
        }

        // print result
        long sum = 0;
        for (int i = 0; i < 8; i++)
        {
            sum += smetalo[i];
        }

        int emptyCols = 0;
        int[] bitColCount = new int[width];
        for (int i = 0; i < smetalo.Length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                long bit = (smetalo[i] & (1 << j)) >> j;
                bitColCount[j] += (int)bit;
            }
        }

        for (int i = 0; i < bitColCount.Length; i++)
        {
            emptyCols += bitColCount[i] == 0 ? 1 : 0;
        }

        Console.WriteLine(sum * emptyCols);
    }
}