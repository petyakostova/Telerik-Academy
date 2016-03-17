/*  Problem 1. Leap year
    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
 */

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        bool isLeap = DateTime.IsLeapYear(year);

        Console.Write("The year {0} is ", year);
        if (!isLeap)
        {
            Console.Write("NOT ");
        }
        Console.WriteLine("a leap year.");
    }
}