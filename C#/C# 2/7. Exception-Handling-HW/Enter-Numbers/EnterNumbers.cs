/*  2. Enter numbers
    Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
    If an invalid number or non-number text is entered, the method should throw an exception. 
    Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 0 < a1 < ... < a10 < 100
    Input: You will receive 10 lines of input, each consisted of an integer number
            a1
            a2
            ...
            a10
    Output: 
            Print 1 < a1 < ... < a10 < 100
            Or Exception if the above inequality is not true
    Sample tests:
    Input: 	    Output:                                                     Input:      Output:
    5           1 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100     87          Exception
    7                                                                       10
    15                                                                      29
    29                                                                      28
    46                                                                      43
    47                                                                      58
    60                                                                      95
    70                                                                      41
    89                                                                      2
    98 	                                                                    46
 */

using System;
using System.Collections.Generic; // needed for List<int>
using System.Linq; // needed for Any()

class EnterNumbers
{
    static int start = 0;
    static int end = 100;
    const int count = 10;

    static void Main()
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < count; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        try
        {
            if (numbers.Any(x => x < start) || numbers.Any(x => x > end) || !IsIncreasing(numbers))
            {
                throw new ArgumentException();
            }

            Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }

    }

    private static bool IsIncreasing(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            /* public Int32 CompareTo(Int32 value); => Compares this instance to a specified 32-bit signed integer 
            and returns an indication of their relative values. 
            Returns а signed number indicating the relative values of this instance and value. 
            Return Value Description Less than zero This instance is less than value. 
            Zero This instance is equal to value. Greater than zero This instance is greater than value. */
            if (numbers[i - 1].CompareTo(numbers[i]) >= 0)
            {
                return false;
            }
        }

        return true;
    }
}