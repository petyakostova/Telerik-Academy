/*Problem 7. Sort 3 Numbers with Nested Ifs
  Write a program that enters 3 real numbers and prints them sorted in descending order.
  Use nested if statements.
  Note: Don’t use arrays and the built-in sorting functionality.
Examples:
a 	    b 	    c 	        result
5 	    1 	    2 	        5 2 1
-2 	    -2 	    1 	        1 -2 -2
-2 	    4 	    3 	        4 3 -2
0 	    -2.5 	5 	        5 0 -2.5
-1.1 	-0.5 	-0.1 	    -0.1 -0.5 -1.1
10 	    20 	    30 	        30 20 10
1 	    1 	    1 	        1 1 1
*/

using System;
using System.Globalization;
using System.Threading;

class Sort3NumbersNestedIfs
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/*changes the culture of the program in American standard
                                                                             so the decimal point character is . */
        double a, b, c;
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
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else
        {
            if (a > b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}