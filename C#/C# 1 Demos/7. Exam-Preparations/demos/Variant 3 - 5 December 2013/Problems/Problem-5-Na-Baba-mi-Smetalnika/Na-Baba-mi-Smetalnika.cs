using System;

internal class Smetalnik
{
    private static void Main()
    {
        //Console.BufferHeight = 10000;
        const string SORT_CMD = "reset";
        const string RIGHT_CMD = "right";
        const string END_CMD = "stop";
        
        // Input
        int abacusWidth = int.Parse(Console.ReadLine());

        long line0 = long.Parse(Console.ReadLine());
        long line1 = long.Parse(Console.ReadLine());
        long line2 = long.Parse(Console.ReadLine());
        long line3 = long.Parse(Console.ReadLine());
        long line4 = long.Parse(Console.ReadLine());
        long line5 = long.Parse(Console.ReadLine());
        long line6 = long.Parse(Console.ReadLine());
        long line7 = long.Parse(Console.ReadLine());

        //PrintLines(line0, line1, line2, line3, line4, line5, line6, line7, abacusWidth);

        // Init
        long initialNumber = 0;
        int bitsCount = 0;
        string currentCommand;
        byte currentRowIndex;
        int position;
        long currentRow = 0;
        long mask;

        // Creating the initial numbre for fast sorting
        for (int i = abacusWidth - 1; i >= 0; i--)
        {
            if ((line0 & (1L << i)) > 0)
            {
                bitsCount++;
            }
        }

        for (int i = 0; i < bitsCount; i++)
        {
            initialNumber |= 1L << (abacusWidth - (1 + i));
        }

        // Executing commands
        while (true)
        {
            currentCommand = Console.ReadLine().Trim().ToLower();

            if (currentCommand == END_CMD)
            {
                break;
            }

            if (currentCommand == SORT_CMD)
            {
                line0 = initialNumber;
                line1 = initialNumber;
                line2 = initialNumber;
                line3 = initialNumber;
                line4 = initialNumber;
                line5 = initialNumber;
                line6 = initialNumber;
                line7 = initialNumber;
            }
            else
            {
                currentRowIndex = byte.Parse(Console.ReadLine());
                position = int.Parse(Console.ReadLine());
                if (position < 0)
                {
                    position = 0;
                }
                if (position >= abacusWidth)
                {
                    position = abacusWidth - 1;
                }

                position++;
                position = abacusWidth - position;

                // Selecting the requested row
                switch (currentRowIndex)
                {
                    case 0:
                        currentRow = line0;
                        break;

                    case 1:
                        currentRow = line1;
                        break;

                    case 2:
                        currentRow = line2;
                        break;

                    case 3:
                        currentRow = line3;
                        break;

                    case 4:
                        currentRow = line4;
                        break;

                    case 5:
                        currentRow = line5;
                        break;

                    case 6:
                        currentRow = line6;
                        break;

                    case 7:
                        currentRow = line7;
                        break;

                    default:
                        // Foierverki...
                        break;
                }

                bitsCount = 0;

                if (currentCommand == RIGHT_CMD)
                {
                    for (int i = 0; i <= position; i++)
                    {
                        mask = 1L << i;

                        if ((currentRow & mask) > 0)
                        {
                            currentRow ^= mask;
                            currentRow |= 1L << bitsCount++;
                        }
                    }
                }
                else // LEFT_CMD
                {
                    for (int i = abacusWidth - 1; i >= position; i--)
                    {
                        mask = 1L << i;

                        if ((currentRow & mask) > 0)
                        {
                            currentRow ^= mask;
                            currentRow |= 1L << (abacusWidth - (1 + bitsCount++));
                        }
                    }
                }

                // Updating the current row
                switch (currentRowIndex)
                {
                    case 0:
                        line0 = currentRow;
                        break;

                    case 1:
                        line1 = currentRow;
                        break;

                    case 2:
                        line2 = currentRow;
                        break;

                    case 3:
                        line3 = currentRow;
                        break;

                    case 4:
                        line4 = currentRow;
                        break;

                    case 5:
                        line5 = currentRow;
                        break;

                    case 6:
                        line6 = currentRow;
                        break;

                    case 7:
                        line7 = currentRow;
                        break;

                    default:
                        // Foierverki...
                        break;
                }
            }

            //PrintLines(line0, line1, line2, line3, line4, line5, line6, line7, abacusWidth);
        }

        // Calculating result
        long result = line0 + line1 + line2 + line3 + line4 + line5 + line6 + line7;

        int emptyColsCount = 0;
        bool isColEmpty = true;

        for (int i = 0; i < abacusWidth; i++)
        {
            mask = 1L << i;

            if ((line0 & mask) > 0 ||
                (line1 & mask) > 0 ||
                (line2 & mask) > 0 ||
                (line3 & mask) > 0 ||
                (line4 & mask) > 0 ||
                (line5 & mask) > 0 ||
                (line6 & mask) > 0 ||
                (line7 & mask) > 0
                )
            {
                isColEmpty = false;
            }

            if (isColEmpty)
            {
                emptyColsCount++;
            }

            isColEmpty = true;
        }

        result *= emptyColsCount;
        
        // Output Result
        Console.WriteLine(result);
    }

    //private static void PrintLines(long l0, long l1, long l2, long l3, long l4, long l5, long l6, long l7, int width)
    //{
    //    Console.WriteLine();
    //    PrintBitNum(l0, width);
    //    PrintBitNum(l1, width);
    //    PrintBitNum(l2, width);
    //    PrintBitNum(l3, width);
    //    PrintBitNum(l4, width);
    //    PrintBitNum(l5, width);
    //    PrintBitNum(l6, width);
    //    PrintBitNum(l7, width);
    //    Console.WriteLine();
    //}

    //private static void PrintBitNum(long num, int width)
    //{
    //    Console.WriteLine(Convert.ToString(num, 2).PadLeft(width, '0') + " -> " + num);
    //}
}