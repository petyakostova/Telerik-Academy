/* Problem 1. Exchange If Greater
   Write an if-statement that takes two double variables a and b and exchanges their values 
   if the first one is greater than the second one. As a result print the values a and b, separated by a space.
Examples:
a 	    b 	    result
5 	    2 	    2 5
3 	    4 	    3 4
5.5 	4.5 	4.5 5.5
*/

using System;
using System.Globalization;                                                     // line 12 and 13 are necessary for the line 19
using System.Threading;

class ExchangeIfTheFirstIsGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/* changes the culture of the program in American standard
                                                                            * so the decimal point character is . */
        double a, b;                                                            
        Console.Write("Enter the first number a = ");
        while (!double.TryParse(Console.ReadLine(), out a))                 // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct number a = ");
        }
        Console.Write("Enter the second number b = ");
        while (!double.TryParse(Console.ReadLine(), out b))                 // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct number b = ");
        }
        if (a > b)
        {
            b += a;                                                         // exchange the values - first way
            a = b - a;
            b = b - a;
            //double helpingExchangeVar = a;                                // exchange the values - second way
            //a = b;
            //b = helpingExchangeVar;             
        }
        Console.WriteLine(a + " " + b);
    }
}