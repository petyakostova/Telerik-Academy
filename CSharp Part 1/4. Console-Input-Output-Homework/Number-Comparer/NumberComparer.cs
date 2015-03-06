/* Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
Examples:
a 	    b 	    greater
5 	    6 	    6
10 	    5 	    10
0 	    0 	    0
-5 	    -2 	    -2
1.5 	1.6 	1.6                     */

using System;
using System.Threading;                                                     // line 13 and 14 are necessary for the line 20
using System.Globalization;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; /* changes the culture of the program in American standard
                                                                                 * so the decimal point character is . */
        double a, b;
        Console.Write("Enter the number a= ");
        while (!double.TryParse(Console.ReadLine(), out a))                // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct number a= ");
        }
        Console.Write("Enter the number b= ");
        while (!double.TryParse(Console.ReadLine(), out b))               // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct number b= ");
        }
        // first way
        double greater = Math.Max(a, b);                                        // using of the function Math.Max(a,b)
        Console.WriteLine("The greater of {0} and {1} is {2}", a, b, greater);
        // second way
        //Console.WriteLine("The greater of {0} and {1} is {2}", a, b, (a + b + Math.Abs(a - b)) / 2);    // using of the function Math.Abs(a) for taking the absolute value of a number a
        
        //Console.WriteLine("The smaller of {0} and {1} is {2}", a, b, (a + b - Math.Abs(a-b)) / 2); // prints the smaller number  
    }
}