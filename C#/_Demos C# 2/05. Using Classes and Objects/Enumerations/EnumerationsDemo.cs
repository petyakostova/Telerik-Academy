using System;

class EnumerationsDemo
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };

    static void Main()
    {
        Day day = Day.Monday;
        Console.WriteLine(day); // Monday

        // This will not compile
        //Day first = 1;

        Day nextDay = day + 1;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(nextDay); // Tuesday

        Day thirdDay = (Day)3;
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(thirdDay);    // Thursday

        string sundayStr = "Sunday";
        Day sunday = (Day)Enum.Parse(typeof(Day), sundayStr);  // Sunday
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(sunday);

        Console.ResetColor();
    }
}