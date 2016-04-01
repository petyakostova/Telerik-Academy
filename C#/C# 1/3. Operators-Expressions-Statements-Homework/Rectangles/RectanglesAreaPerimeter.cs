/* Problem 4. Rectangles
Write an expression that calculates rectangle’s area and perimeter by given width and height. */

using System;
using System.Threading;                                                     
using System.Globalization;

class RectanglesAreaPerimeter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     

        double width = double.Parse(Console.ReadLine()); 
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        //Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        //Console.WriteLine("{0} {1}", area.ToString("F2"), perimeter.ToString("F2"));
    }
}