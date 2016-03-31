/* 3. Circle Perimeter and Area
   Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point. On the only line of the input you will receive the radius of the circle - r. You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision. Constraints: The radius r will always be a valid and positiv real number.*/

using System;
using System.Threading;                                                     
using System.Globalization;

class CirclePerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; 

        double r = double.Parse(Console.ReadLine());

        double p = 2 * Math.PI * r;
        double s = Math.PI * r * r;

        Console.WriteLine("{0:0.00} {1:F2}", p, s);    // formatted with 2 digits after the decimal point
        //Console.WriteLine("{0} {1}", Math.Round(p, 2), Math.Round(s, 2)); // rounded and formatted - second way
    }
}