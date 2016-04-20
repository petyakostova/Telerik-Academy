using System;

class UKFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // part 1
        Console.WriteLine("\\{0}|{0}/", new string('.', n / 2 - 1));

        // part 2
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('.', 1 + i), new string('.', n / 2 - 2 - i));
        }

        // part 3
        Console.WriteLine("{0}\\|/{0}", new string('.', n / 2 - 1));

        // part 4
        Console.WriteLine("{0}*{0}", new string('-', n / 2));

        // part 5
        Console.WriteLine("{0}/|\\{0}", new string('.', n / 2 - 1));

        // part 6
        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}/{1}|{1}\\{0}", new string('.', n / 2 - 2 - i), new string('.', 1 + i));
        }

        // part 7
        Console.WriteLine("/{0}|{0}\\", new string('.', n / 2 - 1));

    }
}