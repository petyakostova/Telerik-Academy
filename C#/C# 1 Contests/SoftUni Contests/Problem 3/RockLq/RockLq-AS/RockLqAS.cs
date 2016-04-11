using System;

class RockLqAS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n)); // part 1

        int dotsBefore = n;
        int dotsMiddle = n + 2;
        for (int i = 0; i < n / 2; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle)); // part 2
            dotsMiddle += 4;
        }

        dotsBefore = n - 2;
        dotsMiddle = n;
        int dotsBetween = 1;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', dotsBefore), new string('.', dotsMiddle)); // part 3

        for (int i = 0; i < (n / 2) - 1; i++)
        {
            dotsBefore -= 2;
            Console.WriteLine("*{0}*{2}*{1}*{2}*{0}*",
                new string('.', dotsBefore), new string('.', dotsMiddle), new string('.', dotsBetween)); // part 4
            dotsBetween += 2;
        }

        dotsBefore = n - 2;
        dotsBefore++;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle)); // part 5
            dotsBefore--;
            dotsMiddle += 2;
        }

        Console.WriteLine(new string('*', n * 3)); // part 6
    }
}