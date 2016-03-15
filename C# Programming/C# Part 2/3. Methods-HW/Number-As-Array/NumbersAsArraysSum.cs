/*  Problem 8. Number as array
    Write a method that adds two positive positive numbers represented as arrays of digits 
    (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
    Each of the numbers that will be added could have up to 10 000 digits.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class NumbersAsArraysSum
{
    static void Main()
    {
        Console.Write("Enter the first positive positive number: ");
        string firstNum = Console.ReadLine();
        Console.Write("Enter the second positive positive number: ");
        string secondNum = Console.ReadLine();

        if (IsCorrectNumber(firstNum) && IsCorrectNumber(secondNum))
        {
            List<int> result = AccumulateTwoNumbers(firstNum, secondNum);
            Console.WriteLine("Sum:");
            PrintResult(result);
        }
        else
        {
            Console.WriteLine("\nYou have entered invalid number(s).\n");
        }
    }

    static bool IsCorrectNumber(string number)
    {
        return number.All(t => t >= '0' && t <= '9');
    }

    static List<int> AccumulateTwoNumbers(string firstNum, string secondNum)
    {
        // Convert string to int[] according to the assignment to represent numbers as array of digits
        var firstArray = firstNum.Select(ch => ch - '0').ToArray();
        var secondArray = secondNum.Select(ch => ch - '0').ToArray();

        Array.Reverse(firstArray);
        Array.Reverse(secondArray);

        List<int> result = new List<int>(Math.Max(firstArray.Length, secondArray.Length));

        int left = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < firstArray.Length ? firstArray[i] : 0) + (i < secondArray.Length ? secondArray[i] : 0) + left;            
            result.Add(num % 10);
            left = num / 10;
        }

        if (left > 0) result.Add(left);

        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine("\n");
    }

}