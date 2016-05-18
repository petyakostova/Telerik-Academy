/*  10. N Factorial
    Write a method that multiplies a number represented as an array of digits by a given integer number. 
    Write a program to calculate N!.
    Input: On the first line you will receive the number N
    Output: Print N!
    Constraints: 0 <= N <= 100
    Sample tests:
                    Input 	Output
                    5 	    120                 */

using System;
using System.Collections.Generic;
using System.Linq; // needed fot Select()

class NFactorial
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());

        // Calculating the factorial
        List<int> factorial = CalculateFactorial(n);

        // Output
        Console.WriteLine(string.Join("", factorial));
    }

    static List<int> CalculateFactorial(int number)
    {
        int[] a = { 1 };

        for (int currNum = 2; currNum <= number; currNum++)
        {
            int left = 0;

            int[] digitsArrayCurrNum = currNum.ToString().Select(ch => ch - '0').ToArray();

            int[] c = new int[a.Length + digitsArrayCurrNum.Length];

            for (int i = a.Length - 1; i >= 0; i--)
            {
                for (int j = digitsArrayCurrNum.Length - 1; j >= 0; j--)
                {
                    c[a.Length - i + digitsArrayCurrNum.Length - j - 2] += a[i] * digitsArrayCurrNum[j];
                }
            }

            for (int i = 0; i < c.Length; i++)
            {
                var digits = c[i] + left;
                c[i] = digits % 10;
                left = digits / 10;
            }

            a = c;

            Array.Reverse(c);
        }

        int start = 0;

        while (a[start] == 0)
        {
            start++;
        }

        List<int> result = new List<int>();

        for (int i = start; i < a.Length; i++)
        {
            result.Add(a[i]);
        }

        return result;
    }
}