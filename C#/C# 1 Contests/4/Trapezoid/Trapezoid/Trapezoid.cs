using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // part 1
        Console.WriteLine("{0}{1}", new string('.', n), new string('*', n));

        // part 2
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*", new string('.', n - 1 - i), new string('.', n - 1 + i));
        }

        // part 3
        Console.WriteLine(new string('*', 2 * n));

    }
}
