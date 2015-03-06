/*  Problem 5. Workdays
    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday 
    except a fixed list of public holidays specified preliminary as array.
 */

using System;
using System.Collections.Generic;
class Workdays
{
    static List<DateTime> publicHolydays;

    static void Main()
    {
        publicHolydays = new List<DateTime>()
        {new DateTime(2015, 1, 1),new DateTime(2015, 3, 2),new DateTime(2015, 3, 3),
        new DateTime(2015, 4, 10), new DateTime(2015, 4, 11),new DateTime(2015, 4, 12),new DateTime(2015, 4, 13),
        new DateTime(2015, 5, 1),new DateTime(2015, 5, 6),new DateTime(2015, 9, 21), new DateTime(2015, 9, 22),
        new DateTime(2015, 12, 24),new DateTime(2015, 12, 25),new DateTime(2015, 12, 26),new DateTime(2015, 12, 31),};

        DateTime currentDate = DateTime.Today;  // gets the current date
        //Console.WriteLine(Convert.ToString(currentDate.ToShortDateString()));   // prints only the current date

        Console.Write("Enter a date in format (dd.mm.yyyy): ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(date.ToShortDateString()));  // prints only the input date        

        Console.WriteLine(CountWorkdays(currentDate, date));
    }

    private static string CountWorkdays(DateTime startDate, DateTime endDate)
    {
        int workDays = 0;
        int holydays = 0;
        int weekends = 0;
        
        while (startDate <= endDate)
        {
            if (publicHolydays.Contains(startDate))
            {
                holydays++;
            }
            else if ((int)startDate.DayOfWeek == 6 || (int)startDate.DayOfWeek == 0)    // 6 => Suturday; 0 => Sunday
            {
                weekends++;
            }
            else
            {
                workDays++;
            }               
 
            startDate = startDate.AddDays(1);
        }

        return String.Format(@"
        Holydays: {0}
        Weekends: {1}
        Workdays: {2}
        ", holydays, weekends, workDays);
    }
}