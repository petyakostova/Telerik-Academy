using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // part 1
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', 0 + i), new string('*', n - 2 * i));
        }

        // part 2
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2 - i), new string('*', 1 + 2 * i));
        }

    }
}