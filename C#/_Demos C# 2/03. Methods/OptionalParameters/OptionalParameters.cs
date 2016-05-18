using System;

class OptionalParameters
{
    static void PrintNumbers(int start = 0, int end = 20)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        PrintNumbers(5, 10); // 5 6 7 8 9 10
        PrintNumbers(15); // 15 16 17 18 19 20
        PrintNumbers(); // 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
        PrintNumbers(end: 40, start: 35); // 35 36 37 38 39 40
    }
}