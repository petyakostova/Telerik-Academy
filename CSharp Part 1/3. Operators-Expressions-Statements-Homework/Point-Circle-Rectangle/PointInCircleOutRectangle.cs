/* Problem 10. Point Inside a Circle & Outside of a Rectangle
   Write an expression that checks for given point (x, y) if it is 
   within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:
x 	    y 	    inside K & outside of R
1 	    2 	    yes
2.5 	2 	    no
0 	    1 	    no
2.5 	1 	    no
2 	    0 	    no
4 	    0 	    no
2.5 	1.5 	no
2 	    1.5 	yes
1 	    2.5 	yes
-100 	-100 	no
*/

using System;
using System.Threading;                                                     // line 19 and 20 are necessary for the line 26
using System.Globalization;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     /* changes the culture of the program in American standard 
                                                                               so the decimal point character is . */
        double x1 = 1;                                                      // circle (01{x1,y1}, r)
        double y1 = 1;                                                      
        double r = 1.5;
        Console.WriteLine("Insert the coordinates of Point (x, y) \n using the decimal point character '.' for real values: ");
        Console.Write("x= ");
        double x2 = double.Parse(Console.ReadLine().Replace(",", "."));     /* parsing and replacing the character ',' with '.'
                                                                             * for ensuring the correct result 
                                                                             * even with introduced ","-format */
        Console.Write("y= ");
        double y2 = double.Parse(Console.ReadLine().Replace(",", "."));             // parcing and replacing
        
        bool insideCircle = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) <= r * r; // using Pythagorean theorem
        double top = 1;                                                             // rectangle's parameters 
        double left = -1;
        double width = 6;
        double height = 2;
        bool insideRectangle = (x2 >= left) && (x2 <= (left + width)) && (y2 >= (top - height)) && (y2 <= top);
        string insideCOutsideR = (insideCircle && !insideRectangle) ? "yes" : "no";
        Console.WriteLine("'The Point ({0}, {1}) is inside the circle and outside of rectangle' = {2}", x2, y2, insideCOutsideR);
    }
}