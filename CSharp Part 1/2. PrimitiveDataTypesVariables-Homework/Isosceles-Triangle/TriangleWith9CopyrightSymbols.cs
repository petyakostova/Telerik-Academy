//Problem 8. Isosceles Triangle
//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//   ©

//  © ©

// ©   ©

//© © © ©

//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8
//and assign a Unicode-friendly font in the console.
//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, 
//regardless of how much effort you put to fix it.

using System;
class TriangleWith9CopyrightSymbols
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char symbol = (char)0xA9;
        //// other way
        //char symbol = '\u00A9';
        Console.WriteLine("   " + symbol + "   ");
        Console.WriteLine("  " + symbol + " " + symbol + "  ");
        Console.WriteLine(" " + symbol + "   " + symbol + " ");
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
    }
}