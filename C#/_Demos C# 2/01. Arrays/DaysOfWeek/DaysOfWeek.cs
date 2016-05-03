using System;

public class DaysOfWeek
{
    static void Main()
    {
        // new string[] it's not necessary
        string[] daysOfWeek =               
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