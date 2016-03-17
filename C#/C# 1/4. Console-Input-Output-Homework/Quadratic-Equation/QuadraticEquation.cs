/* Problem 6. Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
and solves it (prints its real roots).
Examples:
a 	    b 	c 	    roots
2 	    5 	-3 	    x1=-3; x2=0.5
-1 	    3 	0 	    x1=3; x2=0
-0.5    4 	-8 	    x1=x2=4
5 	    2 	8 	    no real roots
*/

using System;
using System.Threading;                                                         // line 13 and 14 are necessary for the line 20
using System.Globalization;

class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;     /* changes the culture of the program in American standard
                                                                                 * so the decimal point character is . */
        double a, b, c;
        Console.Write("Enter the coefficient a= ");
        while (!double.TryParse(Console.ReadLine(), out a))                     // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct coefficient a= ");
        }
        Console.Write("Enter the coefficient b= ");
        while (!double.TryParse(Console.ReadLine(), out b))                     // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct coefficient b= ");
        }
        Console.Write("Enter the coefficient c= ");
        while (!double.TryParse(Console.ReadLine(), out c))                    // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct coefficient c= ");
        }
        double x1, x2;
        if (b * b - 4 * a * c < 0)                                              // if (Discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else
        {
            if (b * b - 4 * a * c == 0)                                         // if (Discriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else                                                                // if (Discriminant > 0)
            {
                x1 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("x1 = {0};    x2 = {1}", x1, x2);
            }
        }
    }
}