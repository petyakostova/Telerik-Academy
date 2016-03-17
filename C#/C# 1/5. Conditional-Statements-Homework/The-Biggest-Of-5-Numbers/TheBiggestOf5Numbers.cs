/* Problem 6. The Biggest of Five Numbers
   Write a program that finds the biggest of five numbers by using only five if statements.
Examples:
a 	    b 	    c 	    d 	    e 	    biggest
5 	    2 	    2 	    4 	    1 	    5
-2 	    -22 	1 	    0 	    0 	    1
-2 	    4 	    3 	    2 	    0 	    4
0 	    -2.5 	0 	    5 	    5 	    5
-3 	    -0.5 	-1.1 	-2 	    -0.1 	-0.1
*/

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/*changes the culture of the program in American standard
                                                                             so the decimal point character is . */
        double a, b, c, d, e;
        Console.Write("Enter the real number a= ");
        while (!double.TryParse(Console.ReadLine(), out a))                 // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number a= ");
        }
        Console.Write("Enter the real number b= ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number b= ");
        }
        Console.Write("Enter the real number c= ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number c= ");
        }
        Console.Write("Enter the real number d= ");
        while (!double.TryParse(Console.ReadLine(), out d))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number d= ");
        }
        Console.Write("Enter the real number e= ");
        while (!double.TryParse(Console.ReadLine(), out e))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number e= ");
        }
        double biggest = a;
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine("The biggest number of the five numbers is " + biggest);
    }
}