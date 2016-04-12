using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidaysCount = int.Parse(Console.ReadLine());
        int weekendsHomeCount = int.Parse(Console.ReadLine());

        int weekendsPerYear = 48;
        int normalWeekendsCount = weekendsPerYear - weekendsHomeCount;

        int sundaysAtHome = weekendsHomeCount;

        double notAtWorkPlays = normalWeekendsCount * 3.0 / 4; //all are int => must be 3.00 or 4.00 => double result

        double holidaysPlays = holidaysCount * 2.0 / 3;

        double yearPlays = sundaysAtHome + notAtWorkPlays + holidaysPlays;

        if (leap == "leap")
        {
            yearPlays *= 1.15;
            //yearPlays += yearPlays * 0.15;
        }

        Console.WriteLine(Math.Floor(yearPlays));
        //Console.WriteLine((int)yearPlays);
    }
}