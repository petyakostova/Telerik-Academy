using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // part 1
        Console.WriteLine(new string(' ', n - 1) + new string(':', n));

        // part 2
        Console.WriteLine(new string(' ', n - 2) + ':' + new string('/', n - 2) + new string(':', 2));

        // part 3
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{3}{1}", new string(' ', n - 3 - i), new string(':', 1), new string('/', n - 2), new string('X', 1 + i));
        }

        // part 4
        Console.WriteLine(new string(':', n) + new string('X', n - 2) + ':');

        // part 5
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}{1}{0}{2}{0}{3}", new string(':', 1), new string(' ', n - 2), new string('X', n - 3 - i), new string(' ', 1 + i));
        }

        // part 6
        Console.WriteLine(new string(':', n) + new string(' ', n - 1));

    }
}