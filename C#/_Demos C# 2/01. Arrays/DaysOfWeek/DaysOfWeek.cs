using System;

public class DaysOfWeek
{
    static void Main()
    {
        string[] daysOfWeek =               //new string[] не е нужно да се пише
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        Console.WriteLine(daysOfWeek.Length);

        //daysOfWeek[7] = ""; // IndexOutOfRangeException
    }
}
