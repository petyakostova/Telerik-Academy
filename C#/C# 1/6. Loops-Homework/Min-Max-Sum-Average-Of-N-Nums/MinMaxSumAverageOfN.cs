/* 3. MMSA (Min, Max, Sum, Average) of N Numbers
   Write a program that reads from the console a sequence of N numbers and returns 
   the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
   On the first line, you will receive the number N (1 <= N <= 1000). On each of the next N lines, 
   you will receive a single valid floating-point number that will be in the range [-10000, 10000].
   Output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, 
   the sum on the third and the average on the fourth, in the following format:
                                                                                min=3
                                                                                max=6
                                                                                sum=9
                                                                                avg=4.5               */

using System;
using System.Globalization;
using System.Threading;

class MinMaxSumAverageOfN
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n = int.Parse(Console.ReadLine());
        
        double min = double.MaxValue;
        double max = double.MinValue; 

        double number;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());

            min = Math.Min(min, number);
            max = Math.Max(max, number);
            sum += number;
        }

        Console.WriteLine("min={0:F2} \r\nmax={1:F2} \r\nsum={2:F2} \r\navg={3:F2}", min, max, sum, sum / n);
    }
}