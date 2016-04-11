using System;

class Car
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        // Car roof
        string dots = new string('.', n);
        string asterix = new string('*', n);
        Console.WriteLine(dots + asterix + dots); // part 1

        for (int i = 0; i < n / 2 - 1; i++)
        {
            string dotsOut = new string('.', n - 1 - i);
            string dotsIn = new string('.', n + 2 * i);
            Console.WriteLine(dotsOut + "*" + dotsIn + "*" + dotsOut); // part 2
        }

        //Car body
        asterix = new string('*', n / 2 + 1);
        dots = new string('.', 2 * n - 2); // 3*n - 2*(n / 2 + 1) = 3*n - n - 2 = 2*n - 2
        Console.WriteLine(asterix + dots + asterix); // part 3

        for (int i = 0; i < n / 2 - 2; i++)
        {
            dots = new string('.', 3 * n - 2);
            Console.WriteLine("*" + dots + "*"); // part 4
        }

        asterix = new string('*', 3 * n);
        Console.WriteLine(asterix); // part 5

        //Car tyres
        for (int i = 0; i < n / 2 - 2; i++)
        {
            dots = new string('.', n / 2);
            string dotsIn = new string('.', n / 2 - 1);
            Console.WriteLine(dots + "*" + dotsIn + "*" + dotsIn + dotsIn + "*" + dotsIn + "*" + dots); // part 6
        }

        asterix = new string('*', n / 2 + 1);
        string dotsBetween = new string('.', n - 2); // 2*(n/2 - 1) = n-2
        Console.WriteLine(dots + asterix + dotsBetween + asterix + dots); // part 7
    }
}