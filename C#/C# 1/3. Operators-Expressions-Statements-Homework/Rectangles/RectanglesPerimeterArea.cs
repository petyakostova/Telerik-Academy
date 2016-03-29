﻿/* Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height. */

using System;
using System.Threading;                                                     
using System.Globalization;

class RectanglesPerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     

        double width = double.Parse(Console.ReadLine()); 
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
        //Console.WriteLine("{0:0.00} {1:0.00}", perimeter, area);
        //Console.WriteLine("{0} {1}", perimeter.ToString("F2"), area.ToString("F2"));
    }
}