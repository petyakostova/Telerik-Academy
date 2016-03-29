/* Problem 10. Point, Circle, Rectangle
   Write a program that reads a pair of coordinates x and y and uses an expression to checks for 
   given point (x, y) if it is within the circle K({1, 1}, 1.5) and 
   out of the rectangle R(top=1, left=-1, width=6, height=2).
   You will receive the pair of coordinates on the two lines of the input - on the first line you will find x, and on the second - y. Print inside circle if the point is inside the circle and outside circle if it's outside. Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. */

using System;
using System.Threading;
using System.Globalization;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        double x1 = 1;            // circle (01{x1,y1}, r)
        double y1 = 1;
        double r = 1.5;

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        // using Pythagorean theorem
        bool insideCircle = (x - x1) * (x - x1) + (y - y1) * (y - y1) <= r * r;

        // rectangle's parameters
        double top = 1;
        double left = -1;
        double width = 6;
        double height = 2;

        bool insideRectangle = (x >= left) && (x <= (left + width)) && (y >= (top - height)) && (y <= top);

        Console.Write(insideCircle ? "inside circle " : "outside circle ");
        Console.WriteLine(insideRectangle ? "inside rectangle" : "outside rectangle");

        //string insideCOutsideR = (insideCircle && !insideRectangle) ? "yes" : "no"; 
        //Console.WriteLine(insideCOutsideR);       
    }
}