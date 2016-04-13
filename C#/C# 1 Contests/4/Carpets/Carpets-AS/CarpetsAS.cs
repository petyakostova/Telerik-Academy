using System;

public class CarpetsAS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char leftSide = '/';
        char rightSide = '\\';
        char space = ' ';

        int rombStart = (n / 2) - 1;
        int rombEnd = (n / 2);

        for (int row = 0; row < n; row++)
        {
            if (row == (n / 2))
            {
                char helper = leftSide;
                leftSide = rightSide;
                rightSide = helper;

                rombStart = 0;
                rombEnd = n - 1;
            }

            for (int col = 0; col < rombStart; col++)
            {
                Console.Write(".");
            }
            int targets = n - (2 * rombStart);
            for (int col = 0; col < targets; col++)
            {
                if (col < (targets / 2))
                {
                    Console.Write(col % 2 == 0 ? leftSide : space);
                }
                else
                {
                    Console.Write(col % 2 != 0 ? rightSide : space);
                }
            }
            for (int col = 0; col < rombStart; col++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
            if (row < (n / 2))
            {
                rombStart--;
                rombEnd++;
            }
            else
            {
                rombStart++;
                rombEnd--;
            }
        }
    }
}