/* Problem 10.* Beer Time
   A beer time is after 1:00 PM and before 3:00 AM.
   Write a program that enters a time in format “hh:mm tt” 
   (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
   and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. 
   Note: You may need to learn how to parse dates and times. */

using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        DateTime beerTimeStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
        DateTime beerTimeEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 3, 0, 0);
        Console.WriteLine("Enter a time in format \"hh:mm tt\" ");
        Console.WriteLine("(an hour in range [01...12], a minute in range [00…59] and AM / PM designator): ");
        DateTime currentTime;

        // DateTime.TryParseExact Method (String, String, IFormatProvider, DateTimeStyles, DateTime)
        if (DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out currentTime))      
        {
            if (currentTime >= beerTimeStart || currentTime < beerTimeEnd)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}