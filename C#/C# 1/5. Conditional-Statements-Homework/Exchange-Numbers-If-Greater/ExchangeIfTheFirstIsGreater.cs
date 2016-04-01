/* 1. Exchange Numbers
   Write a program that reads two double values from the console A and B, stores them in variables and 
   exchanges their values if the first one is greater than the second one. Use an if-statement. 
   As a result print the values of the variables A and B, separated by a space.
   A and B will always be valid real numbers between -100 and 100. */

using System;
using System.Globalization;
using System.Threading;

class ExchangeIfTheFirstIsGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            // exchange the values - first way
            b += a;
            a = b - a;
            b -= a;

            //// exchange the values - second way
            //double helpingExchangeVar = a;                                
            //a = b;
            //b = helpingExchangeVar;             
        }

        Console.WriteLine(a + " " + b);
        //Console.WriteLine("{0} {1}", a, b);
    }
}