/* 5. Number Comparer
   Write a program that gets two numbers from the console and prints the greater of them. 
   Try implementing it without using if-statements. The numbers A and B will always be valid real numbers. */

using System;
using System.Threading;                                                     
using System.Globalization;

class NumberComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        // first way - using of the function Math.Max(a,b)
        double greater = Math.Max(a, b);                                         
        Console.WriteLine(greater);

        //// second way - using the function Math.Abs(a) for taking the absolute value of a number a
        //Console.WriteLine("The greater of {0} and {1} is {2}", a, b, (a + b + Math.Abs(a - b)) / 2);

        //// prints the smaller number  
        //Console.WriteLine("The smaller of {0} and {1} is {2}", a, b, (a + b - Math.Abs(a - b)) / 2); 
    }
}