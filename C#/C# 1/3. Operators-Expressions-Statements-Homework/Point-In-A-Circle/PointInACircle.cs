/* Problem 7. Point in a Circle
   Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle. In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point. The distance should be always printed with 2-digit precision after the floating point. */

using System;
using System.Threading;                                                     
using System.Globalization;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     
        
        double x = double.Parse(Console.ReadLine());        
        double y = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y); // using Pythagorean theorem

        Console.WriteLine((distance <= 2) ? "yes {0:F2}" : "no {0:F2}", distance);               
    }
}