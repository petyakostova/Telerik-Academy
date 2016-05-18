/*  7. Reverse number
    Write a method that reverses the digits of a given decimal number.
    Example:
                input 	    output
                256 	    652
                123.45 	    54.321              */

using System;
using System.Threading;
using System.Globalization;

class DigitsReverse
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine(DigitsReverser(number));
    }

    static decimal DigitsReverser(decimal number)
    {
        string input = number.ToString();

        string reversedNum = null;

        // first way
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedNum += input[i];
        }

        // other way
        //for (int i = 0; i < input.Length; i++)
        //{
        //    reversedNum += input[input.Length - 1 - i];
        //}

        return decimal.Parse(reversedNum);
    }

}