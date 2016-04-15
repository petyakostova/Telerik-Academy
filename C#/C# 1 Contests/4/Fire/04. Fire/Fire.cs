using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}##{0}", new string('.', n / 2 - 1)); // part 1

        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', (n / 2 - 2) - i), new string('.', 2 + 2 * i)); // part 2
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("#{0}#", new string('.', n - 2)); // part 3
        }

        int outDots = 1;
        int middleDots = n - 4;
        while (middleDots >= n / 2)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outDots), new string('.', middleDots)); // part 4
            outDots++;
            middleDots -= 2;
        }

        Console.WriteLine(new string('-', n)); // part 5

        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{0}", 
                new string('.', i), new string('\\', n / 2 - i), new string('/', n / 2 - i)); // part 6
        }

    }
}