/* 4. Formatting Numbers
   Write a program that reads 3 numbers: integer a (0 <= a <= 500), floating-point b, floating-point c.
   The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned.
        Then the number a should be printed in binary form, padded with zeroes.
        The number b should be printed with 2 digits after the decimal point, right aligned.
        The number c should be printed with 3 digits after the decimal point, left aligned. */

using System;
using System.Threading;
using System.Globalization;

class FormattingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int a;
        // parsing and input check (validating the user data)
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 500)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct integer number a (0 <= a <= 500)  a = ");
        }

        double b, c;
        while (!double.TryParse(Console.ReadLine(), out b)) // parsing and input check 
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct floating-point number b = ");
        }
        while (!double.TryParse(Console.ReadLine(), out c)) // parsing and input check
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter a correct floating-point number c = ");
        }

        // printed in hexadecimal, left aligned| then - in binary form, padded with zeroes 
        Console.Write("{0,-10:X}|{1}", a, Convert.ToString(a, 2).PadLeft(10, '0'));        

        // printed with 2 digits after the decimal point, right aligned  
        Console.Write("|{0,10:0.00}", b);

        // printed with 3 digits after the decimal point, left aligned
        Console.WriteLine("|{0,-10:0.000}|", c);
    }
}