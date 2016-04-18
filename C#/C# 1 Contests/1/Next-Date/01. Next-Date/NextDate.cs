using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, month, day);
        DateTime nextDate = date.AddDays(1);

        Console.WriteLine("{0}.{1}.{2}", nextDate.Day, nextDate.Month, nextDate.Year);
    }
}