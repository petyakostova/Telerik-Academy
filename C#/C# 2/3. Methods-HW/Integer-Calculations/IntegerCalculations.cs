/*  14. Integer calculations
    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
    Use variable number of arguments. 
    Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
    Input: On the first line you will receive 5 numbers separated by spaces
    Output: 
            Print their minimum, maximum, average, sum and product - each on a new line.
            The average value should be printed with two digits of precision.
    Constraints: Each of the five numbers will be in the interval [ -1000, 1000 ]
    Sample tests: 
                    Input 	            Output
                    3 7 9 18 0 	        0
                                        18
                                        7.40
                                        37
                                        0                        */

using System;
using System.Collections.Generic;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        // Input
        int[] numbersArray = Console.ReadLine()
            .Split(' ')
            .Select(n => int.Parse(n))
            .ToArray();

        // Output
        Console.WriteLine(Min(numbersArray));
        Console.WriteLine(Max(numbersArray));
        Console.WriteLine("{0:F2}", Average(numbersArray));
        Console.WriteLine(Sum(numbersArray));
        Console.WriteLine(Product(numbersArray));
    }

    static int Min(params int[] array)
    {
        return array.Min();
    }

    static int Max(params int[] array)
    {
        return array.Max();
    }

    static double Average(params int[] array)
    {
        List<int> list = array.ToList();

        return list.Average();
    }

    static long Sum(params int[] array)
    {
        return array.Sum();
    }

    static long Product(params int[] array)
    {
        long product = 1;

        foreach (var num in array)
        {
            product *= num;
        }

        return product;
    }

}