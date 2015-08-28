/* Problem 5. Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:
n 	        Third digit 7?
5 	        false
701 	    true
9703 	    true
877 	    false
777877 	    false
9999799     true            */

using System;

class WhetherThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Insert a number of type Integer: ");
        int intNumber = int.Parse(Console.ReadLine());      /* Read the input as a string (using ReadLine()) and convert this string to a number. 
                                                             * The operation of converting a string into another type is called parsing. */
        if (intNumber < 100)
        {
            Console.WriteLine("'The third digit from right-to-left is 7' = false");
        }
        else
        {
            int dividedBy100 = intNumber / 100;
            int remainderBy10 = dividedBy100 % 10;
            Console.WriteLine((remainderBy10 == 7) ? "'The third digit from right-to-left is 7' = true" : "'The third digit from right-to-left is 7' = false");
        }
    }
}