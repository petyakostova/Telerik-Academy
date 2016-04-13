/* 6. Biggest of 5 Numbers
   Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
   The 5 numbers will always be valid floating-point numbers in the range [-200, 200]. */

using System;
using System.Globalization;
using System.Threading;

class BiggestOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());


        double biggest = a;
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);

        // other way
        //Console.WriteLine(Math.Max(Math.Max(Math.Max(a, b), Math.Max(c, d)), e));
    }
}