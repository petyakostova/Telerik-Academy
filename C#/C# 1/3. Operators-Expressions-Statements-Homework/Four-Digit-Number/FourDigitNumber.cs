/* Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
Examples:
n 	    sum of digits 	reversed 	last digit in front 	second and third digits exchanged
2011 	4 	            1102 	    1201 	                2101
3333 	12 	            3333 	    3333 	                3333
9876 	30 	            6789 	    6987 	                9786                                    */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Insert a four-digit integer number: ");
        int number = int.Parse(Console.ReadLine());                     //parsing
        while ((number < 1000) || (number > 9999))                      //if we want to check
        {
            Console.WriteLine("Incorrect number format. Please insert a four-digit integer number: ");
            number = int.Parse(Console.ReadLine());
        }
        int digit4 = number % 10;
        int digit3 = number / 10 % 10;
        int digit2 = number / 100 % 10;
        int digit1 = number / 1000;
        Console.WriteLine("The sum of the digits is: " + (digit1 + digit2 + digit3 + digit4));
        Console.WriteLine("The number in reversed order: {3}{2}{1}{0}", digit1, digit2, digit3, digit4);
        Console.WriteLine("Putting the last digit in front: {3}{0}{1}{2}", digit1, digit2, digit3, digit4);
        Console.WriteLine("Exchanging the second and the third digits: {0}{2}{1}{3}", digit1, digit2, digit3, digit4);
    }
}