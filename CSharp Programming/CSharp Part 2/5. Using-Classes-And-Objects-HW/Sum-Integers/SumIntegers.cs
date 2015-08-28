/*  Problem 6. Sum integers
    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
    Example:
                input 	                output
                "43 68 9 23 318" 	    461
 */

using System;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter integer numbers given in a single line, separated by a space: ");
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

        //string[] splitNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += int.Parse(splitNumbers[i]);
        }

        Console.WriteLine(sum);

    }
}