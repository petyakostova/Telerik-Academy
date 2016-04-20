using System;

class Eggcelent
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int widhtDraw = 3 * n + 1;
        int eggTop = n - 1; //top = bottom = n - 1
        int eggWidth = 3 * n - 1;

        // part 1
        Console.WriteLine("{0}{1}{0}", new string('.', (widhtDraw - eggTop) / 2), new string('*', eggTop));

        // part 2
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            // ((3 * n + 1) - (n - 1) - 4) / 2 = (2 * n - 2) / 2 = n - 1
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - 2 * i), new string('.', eggTop + 2 + 4 * i));
        }

        // part 3
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine(".*{0}*.", new string('.', 3 * n - 3)); // 3 * n + 1 - 4
        }

        // part 4 - the cracks-1
        Console.Write(".*");
        for (int i = 0; i < 3 * n - 3; i++) // 3 * n + 1 - 4
        {
            if (i % 2 == 0)
            {
                Console.Write("@");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine("*.");

        // part 5 - the cracks-2
        Console.Write(".*");
        for (int i = 0; i < 3 * n - 3; i++) // 3 * n + 1 - 4
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("@");
            }
        }
        Console.WriteLine("*.");

        // part 6 - like part 3
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine(".*{0}*.", new string('.', 3 * n - 3)); // 3 * n + 1 - 4
        }

        // part 7 
        for (int i = 0; i < (n - 2) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', 3 + 2 * i), new string('.', 3 * n - 7 - 4 * i)); // (3 * n + 1 - 4) - 4
        }

        // part 8 - like part 1
        Console.WriteLine("{0}{1}{0}", new string('.', (widhtDraw - eggTop) / 2), new string('*', eggTop));

    }
}