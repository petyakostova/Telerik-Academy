/*  Problem 17. Date in Bulgarian
    Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
    and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Globalization; // needed for CultureInfo
using System.Threading;     // needed for Thread

class DateInBulgarian
{
    static void Main()
    {
        // for easier testing
        string input = "01.03.2015 00:00:00";
        //// the real input
        //Console.WriteLine("Enter a date and time in the format [day.month.year hour:minute:second]: ");
        //string input = Console.ReadLine();

        DateTime dateAndTime = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        dateAndTime = dateAndTime.AddHours(6.5);    // adding 6 hours and 30 minutes <= DateTime DateTime.AddHours(double value)
        //dateAndTime = dateAndTime.AddHours(6).AddMinutes(30); // other way

        Console.WriteLine("{0} {1}", dateAndTime.ToString("dddd", new CultureInfo("bg-BG")), dateAndTime);
        // dddd => formatting string for dates => return day of Week as word
                
    }
}