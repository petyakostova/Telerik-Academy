/* Problem 1. Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.

Examples:
a 	    b 	    c 	    sum
3 	    4 	    11 	    18
-2 	    0 	    3 	    1
5.5 	4.5 	20.1 	30.1        */

using System;
using System.Threading;                                                     // line 11 and 12 are necessary for the line 18
using System.Globalization;

class SumOf3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; /* changes the culture of the program in American standard
                                                                             * so the decimal point character is . */
        double a, b, c;
        Console.Write("Enter the first real number: ");
        while ((double.TryParse(Console.ReadLine(), out a)) == false)       // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number: ");
        }
        Console.Write("Enter the second real number: ");
        while (!double.TryParse(Console.ReadLine(), out b))                 // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number: ");
        }
        Console.Write("Enter the third real number: ");
        while (!double.TryParse(Console.ReadLine(), out c))                 // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number: ");
        }
        Console.WriteLine(Environment.NewLine + "{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}