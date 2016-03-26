//Problem 15. Age after 10 Years
//Description => Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.
//Input => The input will always consist of a single line - a birth date.
//Output => You should print two lines with one number on the each line: 
//    How old are you now, on the first line.
//    How old will you be after 10 years, on the second line.

using System;

class AgeAfter10Years
{
    static void Main()
    {        
        //Console.Write("Which date were you born (dd.mm.yyyy): ");
        // use the Convert.ToDateTime(String) method to convert a string-based date to a System.DateTime object
        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

        DateTime presentYear = DateTime.Now;        
        TimeSpan ts = presentYear - dateOfBirth;

        // DateTime.MinValue => 1.1.0001 г. 0:00:00
        DateTime Age = DateTime.MinValue.AddDays(ts.Days);

        Console.WriteLine(Age.Year - 1);
        //Console.WriteLine("Now you're at:  {0} Years {1} Month {2} Days", Age.Year - 1, Age.Month - 1, Age.Day - 1);    
            
        int ageAFterTen = Age.Year + 9;
        Console.WriteLine(ageAFterTen);
        //Console.WriteLine("After 10 years you'll be at: {0} Years {1} Month {2} Days", ageAFterTen, Age.Month - 1, Age.Day - 1);
    }
}