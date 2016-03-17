/* Problem 5. Formatting Numbers
Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.

Examples:
a 	    b 	        c 	        result
254 	11.6 	    0.5 	    FE |0011111110| 11.60|0.500 |
499 	-0.5559 	10000 	    1F3 |0111110011| -0.56|10000 |
0 	    3 	        -0.1234 	0 |0000000000| 3.00|-0.123 |
*/

using System;
using System.Threading;                                                         // line 20 and 21 are necessary for the line 27
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; /* changes the culture of the program in American standard
                                                                                * so the decimal point character is . */
        int a;
        Console.Write("Enter an integer number a= ");
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)         // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct integer number a (0 <= a <= 500)  a = ");
        }
        double b, c;
        Console.Write("Enter a floating-point number b= ");
        while (!double.TryParse(Console.ReadLine(), out b))                          // parsing and input check 
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct floating-point number b = ");
        }
        Console.Write("Enter a floating-point number c= ");
        while (!double.TryParse(Console.ReadLine(), out c))                          // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct floating-point number c = ");
        }
        Console.Write("|{0,-10:X}|{1}", a, Convert.ToString(a, 2).PadLeft(10, '0'));    // number a - printed in hexadecimal, left aligned| then - in binary form, padded with zeroes 
        bool checkB = Convert.ToString(b).IndexOf(".") > 0;    // using method IndexOf(…) - searchs a string (".") within another string b 
        Console.Write(checkB ? "|{0,10:0.00}" : "|{0,10}", b); // number b - printed with 2 digits after the decimal point, right aligned
        bool checkC = Convert.ToString(c).IndexOf(".") > 0;    // using method IndexOf(…) - searchs a string (".") within another string c
        Console.WriteLine(checkC ? "|{0,-10:0.000}|" : "|{0,-10}|", c); // c - printed with 3 digits after the decimal point, left aligned
    }
}