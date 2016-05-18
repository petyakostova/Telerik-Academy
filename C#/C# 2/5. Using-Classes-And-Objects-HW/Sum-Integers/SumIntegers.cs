/*  8. Sum integers
    You are given a sequence of positive integer values written into a string, separated by spaces. 
    Write a function that reads these values from given string and calculates their sum. 
    Write a program that reads a string of positive integers separated by spaces and prints their sum.
    Input: On the only line you will receive a string consisted of positive integers
    Output: Print the sum of the integers
    Constraints: Each number will be in the interval [1, 1000]. There will not be more than 1000 numbers
    Sample tests:
                    Input 	            Output
                    43 68 9 23 318 	    461             */

using System;

class SumIntegers
{
    static void Main()
    {
        string[] splitNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int sum = 0;

        for (int i = 0; i < splitNumbers.Length; i++)
        {
            sum += int.Parse(splitNumbers[i]);
        }

        Console.WriteLine(sum);
    }
}