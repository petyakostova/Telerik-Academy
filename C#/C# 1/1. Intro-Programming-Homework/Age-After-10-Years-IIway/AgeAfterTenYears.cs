using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);

        int Days = (DateTime.Now.Year * 365 + DateTime.Now.DayOfYear)
            - (birthDate.Year * 365 + birthDate.DayOfYear);
        int Years = Days / 365;

        Console.WriteLine(Years);
        Console.WriteLine(Years + 10);
    }
}