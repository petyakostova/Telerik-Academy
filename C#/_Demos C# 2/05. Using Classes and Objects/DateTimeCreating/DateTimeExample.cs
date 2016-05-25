using System;

class DateTimeExample
{
    static void Main()
    {
        DateTime halloween = new DateTime(2011, 10, 31);
        Console.WriteLine(halloween);   // 31.10.2011 ã. 00:00:00 ÷.

        DateTime julyMorning = new DateTime(2011, 7, 1, 5, 52, 0);
        Console.WriteLine(julyMorning); // 1.7.2011 ã. 05:52:00 ÷.

		DateTime dayAfterHalloween = halloween.AddDays(1);
        Console.WriteLine(dayAfterHalloween);   // 1.11.2011 ã. 00:00:00 ÷.
    }
}