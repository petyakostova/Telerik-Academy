using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int bottom = n;
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;
        int sailsHeight = height * 2 / 3; //it's important the operations to be in this order
        int boatBase = height / 3; //it's important the operations to be in this order

        // part 1
        Console.WriteLine("{0}*{0}", new string('.', n));

        // part 2
        Console.WriteLine("{0}***{0}", new string('.', (width - 3) / 2));

        // part 3
        for (int i = 0; i < sailsHeight - 3; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n - 2 - i), new string('.', 1 + i));
        }

        // part 4
        Console.WriteLine(new string('*', width));

        // part 5
        for (int i = 0; i < boatBase - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 1 + i), new string('.', n - 2 - i));
        }

        // part 6
        Console.WriteLine("{0}{1}{0}", new string('.', (width - bottom) / 2), new string('*', bottom));

    }
}