/*  1. Leap year
    Write a program that reads a year from the console and checks whether it is a leap one.
    Hint: Use   System.DateTime.
    Input: On the only line you will receive a number - the year. 
    Output: Print "Leap" or "Common" on a single line depending on the year
    Sample tests:
                    Input 	Output
                    2016 	Leap
                    1996 	Leap
                    1900 	Common
                    2000 	Leap
                    681 	Common
                    3400 	Common                  */

using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        /*  Return an indication whether the specified year is a leap year
            public static bool IsLeapYear(int year);                       */
        bool isLeap = DateTime.IsLeapYear(year);
        
        if (!isLeap)
        {
            Console.WriteLine("Common");
        }
        else
        {
            Console.WriteLine("Leap");
        }
    }
}