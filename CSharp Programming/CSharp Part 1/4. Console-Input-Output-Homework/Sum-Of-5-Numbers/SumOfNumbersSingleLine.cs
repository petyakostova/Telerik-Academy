/* Problem 7. Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:
numbers 	            sum
1 2 3 4 5 	            15
10 10 10 10 10 	        50
1.5 3.14 8.2 -1 0 	    11.84
*/

using System;
using System.Threading;                                                         // line 11 and 12 are necessary for the line 18
using System.Globalization;

class SumOfNumbersSingleLine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;     /* changes the culture of the program in American standard
                                                                                 * so the decimal point character is . */
        Console.WriteLine("Enter 5 numbers given in a single line, separated by a space: ");
        string line = Console.ReadLine();
        // define array of characters-separators ' '    [can be also { ' ', ',', '.' } - for space, comma and dot]
        char[] separators = new char[] { ' ' };
        /* define array of strings and using the built-in functionality of the method Split(…) from the class String, 
         * split the contents of a given Input (which is String) by array of characters–separators, 
           which are passed as an argument of the method. 
           All substrings among which is space will be removed and stored in the splitNumbers array.
         * For removing the empty elements after splitting, we add as a second parameter (argument) the constant 
           StringSplitOptions.RemoveEmptyEntries         so we instruct the method Split(…) to: 
         * Return all substrings from the variable that are split by given list of separators. 
         * Consider two or more neighboring separators as one. */
        string[] splitNumbers = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += double.Parse(splitNumbers[i]);
        }
        Console.WriteLine("sum= " + sum);
    }
}