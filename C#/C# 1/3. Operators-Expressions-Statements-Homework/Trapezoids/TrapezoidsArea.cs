/* Problem 9. Trapezoids
   Write an expression that calculates trapezoid's area by given sides a and b and height h. The three values should be read from the console in the order shown below. All three values will be floating-point numbers in the range [-500, 500]. Output the area with exactly 7-digit precision after the floating point.*/

using System;
using System.Threading;                                                     
using System.Globalization;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");    
      
        double a = double.Parse(Console.ReadLine());        
        double b = double.Parse(Console.ReadLine());          
        double h = double.Parse(Console.ReadLine());

        double area = (a + b) * h / 2;

        Console.WriteLine(area.ToString("F7"));
    }
}