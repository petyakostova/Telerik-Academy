/* Problem 3. Circle Perimeter and Area
Write a program that reads the radius r of a circle and 
prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:
r 	    perimeter 	area
2 	    12.57 	    12.57
3.5 	21.99 	    38.48               */

using System;
using System.Threading;                                                     // line 10 and 11 are necessary for the line 17
using System.Globalization;

class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; /* changes the culture of the program in American standard
                                                                             * so the decimal point character is . */
        double r, p, s;
        Console.Write("Enter the radius of the circle: r= ");
        while (!double.TryParse(Console.ReadLine(), out r))                 // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid radius.");
            Console.Write("Please enter a correct radius (real number): r= ");
        }
        p = 2 * Math.PI * r;
        s = Math.PI * r * r;
        Console.WriteLine("Perimeter= {0:0.00} \r\nArea= {1:F2}", p, s);    // formatted with 2 digits after the decimal point
        //Console.WriteLine("Perimeter= {0} \r\nArea= {1}", Math.Round(p, 2), Math.Round(s, 2)); // rounded and formatted - second way
    }
}