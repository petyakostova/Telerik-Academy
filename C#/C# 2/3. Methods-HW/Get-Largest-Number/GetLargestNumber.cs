/*  2. Get largest number
    Write a method GetMax() with two parameters that returns the larger of two integers. 
    Write a program that reads 3 integers from the console (on a single line separated by spaces)
    and prints the largest of them using the method GetMax().

 */

using System;
using System.Linq; // needed for Select()

class GetLargestNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int maximum = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);

        Console.WriteLine(maximum);
    }

    private static int GetMax(int firstNum, int secondNum)
    {
        //return Math.Max(firstNum, secondNum);
        // other way
        return (firstNum > secondNum) ? firstNum : secondNum;
    }

    // other way - method with 3 parameters
    //static void Main()
    //{
    //    int[] numbers = Console.ReadLine()
    //        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
    //        .Select(int.Parse)
    //        .ToArray();

    //    int maximum = GetMax(numbers[0], numbers[1], numbers[2]);

    //    Console.WriteLine(maximum);

    //}

    //static int GetMax(int one, int two, int three)
    //{
    //    return Math.Max(Math.Max(one, two), three);
    //}

}