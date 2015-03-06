/* Problem 4. Rectangles
Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:
width 	height 	perimeter 	area
3 	    4 	    14 	        12
2.5 	3 	    11 	        7.5
5 	    5 	    20 	        25         */

using System;
using System.Threading;                                                     // line 10 and 11 are necessary for the line 17
using System.Globalization;

class RectanglesPerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     /* changes the culture of the program in American standard 
                                                                               so the decimal point character is . */
        Console.WriteLine("Insert the rectangle’s width \n (for real value please use the decimal point character '.'): ");
        double width = double.Parse(Console.ReadLine().Replace(",", "."));  /* parsing and replacing the character ',' with '.'
                                                                                        * for ensuring the correct result 
                                                                                        * even with introduced ","-format */
        Console.WriteLine("Insert the rectangle’s height \n (for real value please use the decimal point character '.'): ");
        double height = double.Parse(Console.ReadLine().Replace(",", ".")); //parsing and replacing
        Console.WriteLine("The rectangles's perimeter is: " + (2 * (width + height)));
        Console.WriteLine("The rectangles's area is: " + (width * height));
    }
}