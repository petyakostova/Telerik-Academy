using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2)); // part 1

        if (n != 3)
        {
            int outDash = (n - 3) / 2;
            int middleDash = 1;

            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', outDash), new string('-', middleDash)); // part 2
                outDash--;
                middleDash += 2;
            }
        }

        Console.WriteLine("*{0}*", new string('-', n - 2)); // part 3

        if (n != 3)
        {
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', 1 + i), new string('-', (n - 4) - 2 * i)); // part 4
            }
        }

        Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2)); // part 5

    }
}