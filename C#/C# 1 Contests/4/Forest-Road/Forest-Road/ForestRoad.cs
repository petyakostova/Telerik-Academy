using System;

class ForestRoad
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // part 1
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}", new string('.', 0 + i), new string('.', n - 1 - i));
        }

        // part 2
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}", new string('.', n - 2 - i), new string('.', 1 + i));
        }

    }
}