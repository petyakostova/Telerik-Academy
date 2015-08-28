//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Which date were you born (dd.mm.yyyy): ");
        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
        DateTime presentYear = DateTime.Now;
        TimeSpan ts = presentYear - dateOfBirth;
        DateTime Age = DateTime.MinValue.AddDays(ts.Days);        
        Console.WriteLine("Now I'm at:  {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1);        
        int ageAFterTen = Age.Year + 9;
        Console.WriteLine("After 10 Years I'll be at: {0} Years {1} Month {2} Days", ageAFterTen, Age.Month - 1, Age.Day - 1);
    }
}