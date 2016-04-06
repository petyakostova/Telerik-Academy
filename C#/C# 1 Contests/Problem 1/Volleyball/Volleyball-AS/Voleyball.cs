using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int hollidaysCount = int.Parse(Console.ReadLine());
        int weekendsHomeCount = int.Parse(Console.ReadLine());

        int weekendsInYear = 48;
        int normalWeekendsCount = weekendsInYear - weekendsHomeCount;
        double gamesCount =
            normalWeekendsCount * 3.0 / 4.0 +
            weekendsHomeCount * 1.0 +
            hollidaysCount * 2.0 / 3.0;
        if (leap == "leap")
        {
            gamesCount = gamesCount * 1.15;
        }
        Console.WriteLine((int)gamesCount);
    }
}