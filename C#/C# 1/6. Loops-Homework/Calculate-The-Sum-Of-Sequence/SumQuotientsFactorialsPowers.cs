/* 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
   Write a program that, for a given two integer numbers N and x, calculates the sum 
   S = 1 + 1!/x + 2!/x<sup>2</sup> + … + n!/x<sup>N</sup>.
   Use only one loop. Print the result with 5 digits after the decimal point.
   Input: On the first line you will receive one number - N. On the second line you will receive another number - x.
   Output only one number - the sum of the sequence for the given N and x.
   Constraints: 
                N will always be a valid integer between 2 and 20, inclusive.
                X will always be a valid floating-point number between 0 and 100
                X * N will always be less than 50                                       */

using System;
using System.Globalization;
using System.Threading;

class SumQuotientsFactorialsPowers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int number = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;
        int factorial = 1; // factorial must be int

        if (x == 0) // check
        {
            Console.WriteLine("Invalid input!  x != 0");
        }
        else
        {
            // Sum = 0!/X^0 + 1!/X^1 + 2!/X^2 + … + N!/X^N 

            // first way
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;

                sum += factorial / Math.Pow(x, i);
            }

            // second way
            //double power = 1;
            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //    power *= x;
            //    sum += (factorial / power);
            //}

            Console.WriteLine("{0:F5}", sum); // other way {0:0.00000}

        }

    }
}