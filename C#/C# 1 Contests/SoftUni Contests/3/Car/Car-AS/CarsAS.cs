using System;

class CarsAS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int dots = n;
        int stars = n;
        int dotsMiddle = stars;

        Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('*', stars)); // part 1

        for (int i = 0; i < n / 2 - 1; i++)
        {
            dots--;
            Console.WriteLine("{0}*{1}*{0}", new string('.', dots), new string('.', dotsMiddle)); // part 2
            dotsMiddle += 2;
        }

        Console.WriteLine("{0}{1}{0}", new string('*', dots), new string('.', n * 2 - 2)); // part 3  dots=n/2 +1

        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("*{0}*", new string('.', n * 3 - 2)); // part 4
        }

        int middleDots = (n / 2 + 1) + (n - 6) / 2; // n - 2

        Console.WriteLine(new string('*', n * 3)); // part 5

        for (int i = 0; i < n / 2 - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                new string('.', n / 2), new string('.', n / 2 - 1), new string('.', middleDots)); // part 6
        }

        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2), new string('*', n / 2 + 1), new string('.', middleDots)); // part 7
    }
}