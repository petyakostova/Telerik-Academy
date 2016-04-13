/* 5. The Biggest of 3 Numbers
   Write a program that finds the biggest of three numbers that are read from the console.
   The three numbers will always be valid floating-point numbers in the range [-200, 200]. */

using System;
using System.Globalization;
using System.Threading;

class BiggestOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggest = a;
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);

        // other way
        //Console.WriteLine(Math.Max(Math.Max(a, b), c));
    }
}