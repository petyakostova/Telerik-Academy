/*  Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
    Write a program that, for a given two integer numbers n and x, 
    calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
Examples:
    n 	x 	S
    3 	2 	2.75000
    4 	3 	2.07407
    5 	-4 	0.75781                 */

using System;
using System.Globalization;                                         // line 12 and 13 are necessary for the line 19
using System.Threading;

class SumQuotientsFactorialsPowers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;/*changes the culture of the program in American standard
                                                                            * so the decimal point character is . */
        checked
        {
            Console.Write("Enter an integer number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number x = ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Invalid input!  x != 0");
            }
            else
            {
                // Sum = 0!/X^0 + 1!/X^1 + 2!/X^2 + … + N!/X^N 
                // first way
                double sum = 1;                                             // additional variables
                double factorial = 1;
                double power = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                    power *= x;
                    sum += (factorial / power);
                }
                //// second way
                //double sum = 1;                                           // additional variables
                //double factorial = 1;
                //for (int i = 1; i <= n; i++)
                //{
                //    factorial *= i;
                //    sum += factorial / Math.Pow(x, i);
                //}

                Console.WriteLine("sum = {0:F5}", sum);                     // other way {0:0.00000}
            }
        }
    }
}