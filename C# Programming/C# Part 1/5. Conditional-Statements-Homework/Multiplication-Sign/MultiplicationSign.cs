/*Problem 4. Multiplication Sign
  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
  Use a sequence of if operators.
Examples:
a 	    b 	    c 	    result
5 	    2 	    2 	    +
-2 	    -2 	    1 	    +
-2 	    4 	    3 	    -
0 	    -2.5 	4 	    0
-1 	    -0.5 	-5.1 	-                                       */

using System;
using System.Globalization;
using System.Threading;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/* changes the culture of the program in American standard
                                                                            * so the decimal point character is . */
        double a, b, c;
        Console.Write("Enter the real number a = ");
        while (!double.TryParse(Console.ReadLine(), out a))                 // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number a = ");
        }
        Console.Write("Enter the real number b = ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number b = ");
        }
        Console.Write("Enter the real number c = ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct real number c = ");
        }
        int negativeNumbersCount = 0;                                   // counter to keep the number of negative numbers 
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is 0");
        }
        else
        {
            if (a < 0)
            {
                negativeNumbersCount++;
            }
            if (b < 0)
            {
                negativeNumbersCount++;
            }
            if (c < 0)
            {
                negativeNumbersCount++;
            }
            if (negativeNumbersCount % 2 == 0)
            {
                Console.WriteLine("The product is +");      // If the negative multiples are even number, the product is positive.
            }
            else
            {
                Console.WriteLine("The product is -");      //If the count of the negative numbers is odd, the product is negative.
            }
        }
    }
}