/*  16. Date difference
    Write a program that reads two dates in the format: day.month.year 
    and calculates the number of days between them.
    Example:
    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days
 */

using System;
using System.Globalization; // needed for CultureInfo

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string startDate = Console.ReadLine();
        Console.Write("Enter the second datе: ");
        string endDate = Console.ReadLine();

        // first way

        DateTime start = DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: {0} days", Math.Abs((end - start).TotalDays));

        // other way

        //string[] Date1 = startDate.Split('.');
        //string[] Date2 = endDate.Split('.');

        //// DateTime.DateTime(int year, int month, int day)
        //DateTime DateStart = new DateTime(int.Parse(Date1[2]), int.Parse(Date1[1]), int.Parse(Date1[0]));
        //DateTime DateEnd = new DateTime(int.Parse(Date2[2]), int.Parse(Date2[1]), int.Parse(Date2[0]));

        //int daysBetween = Math.Abs((int)(DateEnd - DateStart).TotalDays);
        //Console.WriteLine("Distance: {0} days", daysBetween);

    }
}