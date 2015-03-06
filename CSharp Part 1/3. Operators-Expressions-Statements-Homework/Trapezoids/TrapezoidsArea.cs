/* Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h.

Examples:
a 	    b 	    h 	    area
5 	    7 	    12 	    72
2 	    1 	    33 	    49.5
8.5 	4.3 	2.7 	17.28
100 	200 	300 	45000
0.222 	0.333 	0.555 	0.1540125
*/

using System;
using System.Threading;                                                     // line 14 and 15 are necessary for the line 21
using System.Globalization;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");     /* changes the culture of the program in American standard 
                                                                               so the decimal point character is . */
        Console.WriteLine("Insert the trapezoid’s side a \n (for real value please use the decimal point character '.'): ");
        double a = double.Parse(Console.ReadLine().Replace(",", "."));  /* parsing and replacing the character ',' with '.'
                                                                                        * for ensuring the correct result 
                                                                                        * even with introduced ","-format */
        Console.WriteLine("Insert the trapezoid’s side b \n (for real value please use the decimal point character '.'): ");
        double b = double.Parse(Console.ReadLine().Replace(",", "."));  // parsing and replacing
        Console.WriteLine("Insert the trapezoid’s height h \n (for real value please use the decimal point character '.'): ");
        double h = double.Parse(Console.ReadLine().Replace(",", "."));  // parsing and replacing
        Console.WriteLine("The trapezoid's area is: " + ((a + b) * h / 2));
    }
}