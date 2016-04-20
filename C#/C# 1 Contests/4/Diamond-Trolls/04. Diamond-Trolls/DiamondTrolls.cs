using System;

class DiamondTrolls
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2 + 1;
        int height = (n - 3) / 2 * 3 + 6;
        int top = n;

        // part 1
        Console.WriteLine("{0}{1}{0}", new string('.', (width - top) / 2), new string('*', top));

        // part 2
        for (int i = 0; i < height - n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', height - n - 2 - i), new string('.', height - n - 2 + i));
        }

        // part 3
        Console.WriteLine(new string('*', width));

        // part 4
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 1 + i), new string('.', n - 2 - i));
        }

        // part 5
        Console.WriteLine("{0}***{0}", new string('.', n - 1));

        // part 6
        Console.WriteLine("{0}*{0}", new string('.', n));

    }
}