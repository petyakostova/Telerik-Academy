/* Problem 5. The Biggest of 3 Numbers
   Write a program that finds the biggest of three numbers.
Examples:
a 	    b 	    c 	    biggest
5 	    2 	    2 	    5
-2 	    -2 	    1 	    1
-2 	    4 	    3 	    4
0 	    -2.5 	5 	    5
-0.1 	-0.5 	-1.1 	-0.1
*/

using System;
using System.Globalization;
using System.Threading;

class TheBiggestOf3Numbers
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
        double biggest = a;
        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        Console.WriteLine("The biggest number of the three numbers is " + biggest);
    }
}