using System;

class QuadronacciRectangle
{
    static void Main()
    {
        long numMinus4 = long.Parse(Console.ReadLine());
        long numMinus3 = long.Parse(Console.ReadLine());
        long numMinus2 = long.Parse(Console.ReadLine());
        long numMinus1 = long.Parse(Console.ReadLine());
        long rows = long.Parse(Console.ReadLine());
        long cols = long.Parse(Console.ReadLine());

        long number;
        // printing the first line
        Console.Write("{0} {1} {2} {3}", numMinus4, numMinus3, numMinus2, numMinus1);

        for (int i = 4; i < cols; i++)
        {
            number = numMinus4 + numMinus3 + numMinus2 + numMinus1;
            Console.Write(" " + number);
            numMinus4 = numMinus3;
            numMinus3 = numMinus2;
            numMinus2 = numMinus1;
            numMinus1 = number;
        }

        // printing the rest lines
        Console.WriteLine();
        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                number = numMinus4 + numMinus3 + numMinus2 + numMinus1;
                if (j != 0)
                {
                    Console.Write(" " + number);
                }
                else
                {
                    Console.Write(number);
                }
                numMinus4 = numMinus3;
                numMinus3 = numMinus2;
                numMinus2 = numMinus1;
                numMinus1 = number;
            }
            Console.WriteLine();
        }

    }
}