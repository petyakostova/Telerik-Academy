/*  8. Number as array
    Write a method that adds two positive integer numbers represented as arrays of digits 
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
    Write a program that reads two arrays representing positive integers and outputs their sum.
    Input:
    On the first line you will receive two numbers separated by spaces - the size of each array
    On the second line you will receive the first array
    On the third line you will receive the second array
    Output: Print the sum as an array of digits (as described)
            Digits should be separated by spaces
    Constraints: Each of the numbers that will be added could have up to 10 000 digits.
    Sample tests:
                    Input 	        Output
                    3 4
                    8 3 3
                    6 2 4 2 	    4 6 7 2

                    5 5
                    0 3 9 3 2
                    5 9 5 1 7 	    5 2 5 5 9                            */

using System;
using System.Collections.Generic;
using System.Linq;

class NumbersAsArraysSum
{
    static void Main()
    {
        // Input
        int[] sizes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string firstNumDigits = Console.ReadLine()
            .Replace(" ", string.Empty); // removing the whitespaces
        string secondNumDigits = Console.ReadLine()
            .Replace(" ", string.Empty); // removing the whitespaces

        // Set parameters for the method
        int biggerSize = Math.Max(sizes[0], sizes[1]);
        int smallerSize = Math.Min(sizes[0], sizes[1]);

        string biggerNumDigits;
        string smallerNumDigits;

        if (biggerSize == sizes[0])
        {
            biggerNumDigits = firstNumDigits;
            smallerNumDigits = secondNumDigits;
        }
        else
        {
            biggerNumDigits = secondNumDigits;
            smallerNumDigits = firstNumDigits;
        }

        // Аccumulating the digits
        AddingTwoNumbersDigits(smallerNumDigits, biggerNumDigits, smallerSize, biggerSize);
    }

    private static void AddingTwoNumbersDigits(string smallerNumDigits, string biggerNumDigits,
        int smallerSize, int biggerSize)
    {
        List<int> sumNumsDigits = new List<int>();

        int remainder = 0;

        for (int i = 0; i < smallerSize; i++)
        {
            int result = (int)smallerNumDigits[i] - '0' + (int)biggerNumDigits[i] - '0' + remainder;

            if (result < 10)
            {
                sumNumsDigits.Add(result);
                remainder = 0;
            }
            else
            {
                sumNumsDigits.Add(result % 10);
                remainder = result / 10;
            }
        }

        for (int i = smallerSize; i < biggerSize; i++)
        {
            int result = (int)biggerNumDigits[i] - '0' + remainder;

            if (result < 10)
            {
                sumNumsDigits.Add(result);
                remainder = 0;
            }
            else
            {
                sumNumsDigits.Add(result % 10);
                remainder = result / 10;
            }
        }

        if (remainder > 0)
        {
            sumNumsDigits.Add(remainder);
        }

        // Output
        Console.WriteLine(String.Join(" ", sumNumsDigits));
    }

}