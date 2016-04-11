using System;

class DoubleDowns
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++) //n = numbers.Length
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int rightDiagonal = 0;
        int leftDiagonal = 0;
        int vertical = 0;

        for (int i = 0; i < n - 1; i++) //n = numbers.Length
        {
            int upNum = numbers[i];
            int downNum = numbers[i + 1];

            for (int bit = 0; bit < 32; bit++) //because we use int (32-bit numbers)
            {
                int mask = 1 << bit;

                // check if the current bit is 1
                bool upperNumberMatch = (upNum & mask) > 0;

                if (upperNumberMatch && (downNum & mask) > 0)
                {
                    vertical++;
                }
                // shift the mask to the left to catch the left diagonal
                if (upperNumberMatch && (downNum & mask << 1) > 0)
                {
                    leftDiagonal++;
                }
                // shift the mask to the right to catch the left diagonal
                if (upperNumberMatch && (downNum & mask >> 1) > 0)
                {
                    rightDiagonal++;
                }
            }
        }

        Console.WriteLine(rightDiagonal);
        Console.WriteLine(leftDiagonal);
        Console.WriteLine(vertical);
    }
}