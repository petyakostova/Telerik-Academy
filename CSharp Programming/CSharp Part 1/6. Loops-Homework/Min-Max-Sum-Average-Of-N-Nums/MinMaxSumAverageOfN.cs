/*  Problem 3. Min, Max, Sum and Average of N Numbers
    Write a program that reads from the console a sequence of n integer numbers and returns 
    the minimal, the maximal number, the sum and the average of all numbers 
    (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
Example 1:                      Example 2:
    input 	output                  input 	output
    3       min = 1                 2       min = -1
    2       max = 5                 -1      max = 4
    5       sum = 8                 4 	    sum = 3
    1 	    avg = 2.67                      avg = 1.50                  */
 
using System;
using System.Globalization;                                                 // line 15 and 16 are necessary for the line 22
using System.Threading;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/*changes the culture of the program in American standard
                                                                            *so the decimal point character is . */
        int n, number;
        Console.Write("Enter a positive integer number n = ");
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)   // parsing and input check (validating the user data)
        {
            Console.WriteLine("Incorrect input!");
            Console.Write("Please enter a positive integer number n= ");
        }
        int min = int.MaxValue;                                     // int min = Int32.MaxValue;
        int max = int.MinValue;                                     // int max = Int32.MinValue;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out number))   // parsing and input check
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("Please enter an integer number: ");
            }
            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
        }
        Console.WriteLine("min = {0} \r\nmax = {1}\r\nsum = {2} \r\navg = {3:0.00}", min, max, sum, sum / n);
    }
} 