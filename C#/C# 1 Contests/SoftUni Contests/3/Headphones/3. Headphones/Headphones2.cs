// second way

using System;

class Headphones2
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', d / 2), new string('*', d + 2)); // part 1

        for (int i = 0; i < d - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', d / 2), new string('-', d)); // part 2
        }

        int dashesOut = d / 2;
        int stars = 1;
        int dashesIn = d;
        for (int i = 0; i < d / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', dashesOut), new string('*', stars), new string('-', dashesIn)); // part 3
            stars += 2;
            dashesOut--;
            dashesIn -= 2;
        }

        Console.WriteLine("{0}-{0}", new string('*', d)); // part 4

        dashesOut = 1;
        stars = d - 2;
        dashesIn = 3;
        for (int i = 0; i < d / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', dashesOut), new string('*', stars), new string('-', dashesIn)); // part 5
            stars -= 2;
            dashesOut++;
            dashesIn += 2;
        }
    }
}