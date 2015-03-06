/* Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:
x 	    y 	    inside
0 	    1 	    true
-2 	    0 	    true
-1 	    2 	    false
1.5 	-1 	    true
-1.5 	-1.5 	false
100 	-30 	false
0 	    0 	    true
0.2 	-0.8 	true
0.9 	-1.93 	false
1 	    1.655 	true            */

using System;
using System.Threading;                                                     // line 17 and 18 are necessary for the line 24
using System.Globalization;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     /* changes the culture of the program in American standard 
                                                                               so the decimal point character is . */
        Console.WriteLine("Insert the coordinates of Point (x, y) \n using the decimal point character '.' for real values: ");
        Console.Write("x= ");
        double x = double.Parse(Console.ReadLine().Replace(",", "."));  /* parsing and replacing the character ',' with '.'
                                                                                        * for ensuring the correct result 
                                                                                        * even with introduced ","-format */
        Console.Write("y= ");
        double y = double.Parse(Console.ReadLine().Replace(",", "."));  //parsing and replacing
        Console.WriteLine((x * x + y * y <= 4) ? "inside = true" : "inside = false");       // using Pythagorean theorem        
    }
}