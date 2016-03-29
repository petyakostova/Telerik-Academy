/* Problem 6. Four-Digit Number
   Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
      1. Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
      2. Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
      3. Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
      4. Exchanges the second and the third digits: acbd (in our example 2101) and prints the result. */

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());                     
        
        int digit4 = number % 10;
        int digit3 = number / 10 % 10;
        int digit2 = number / 100 % 10;
        int digit1 = number / 1000;

        Console.WriteLine(digit1 + digit2 + digit3 + digit4);

        if (digit4 != 0)
        {
            Console.WriteLine("{3}{2}{1}{0}", digit1, digit2, digit3, digit4);
        }
        else
        {
            Console.WriteLine((digit3 == 0)
                ? "{1}{0}"
                : "{2}{1}{0}", digit1, digit2, digit3);
        }

        Console.WriteLine((digit4 == 0)
                ? "{0}{1}{2}"
                : "{3}{0}{1}{2}", digit1, digit2, digit3, digit4);

        Console.WriteLine("{0}{2}{1}{3}", digit1, digit2, digit3, digit4);
    }
}