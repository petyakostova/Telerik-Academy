/*  Problem 7. Reverse number
    Write a method that reverses the digits of given decimal number.
    Example:
                input 	    output
                256 	    652
                123.45 	    54.321
 */

using System;
using System.Threading;
using System.Globalization; 

class DigitsReverse
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a decimal number: ");
        double number;  // the type is double because of the second example
        while (!double.TryParse(Console.ReadLine(), out number))
        {            
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct decimal number: ");        
        }

        Console.WriteLine(DigitsReverser(number));
    }

    static double DigitsReverser(double number)
    {
        string input = number.ToString();

        string output = null;

        for (int i = 0; i < input.Length; i++)
        {
            output = output + input[input.Length - 1 - i];
        }

        return double.Parse(output);
    }

}