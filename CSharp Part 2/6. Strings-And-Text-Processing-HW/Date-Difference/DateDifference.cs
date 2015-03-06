/*  Problem 16. Date difference
    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.    
    Example:
            Enter the first date: 27.02.2006
            Enter the second date: 3.03.2006
            Distance: 4 days
 */
// Note: Added file "Example Date Difference.txt" for faster testing

using System;
using System.Globalization; // needed for CultureInfo

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date in the format [d.MM.yyyy]: ");
        string startDate = Console.ReadLine();
        Console.Write("Enter the second date in the format [d.MM.yyyy]: ");
        string endDate = Console.ReadLine();

        DateTime start = DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("\nDistance between {0} and {1} is {2} days\n", startDate, endDate, Math.Abs((end - start).TotalDays));
        
        //// other way
        //string[] Date1 = startDate.Split('.');
        //string[] Date2 = endDate.Split('.');

        //// DateTime.DateTime(int year, int month, int day)
        //DateTime DateStart = new DateTime(int.Parse(Date1[2]), int.Parse(Date1[1]), int.Parse(Date1[0]));
        //DateTime DateEnd = new DateTime(int.Parse(Date2[2]), int.Parse(Date2[1]), int.Parse(Date2[0]));

        //int daysBetween = Math.Abs((int)(DateEnd - DateStart).TotalDays);
        //Console.WriteLine("Distance: {0} days\n", daysBetween);

    }
}