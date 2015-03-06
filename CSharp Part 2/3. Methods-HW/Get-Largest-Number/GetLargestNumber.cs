/*  Problem 2. Get largest number
    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

 */

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Enter first integer : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer : ");
        int thirdNum = int.Parse(Console.ReadLine());

        int maximum = GetMax(GetMax(firstNum, secondNum), thirdNum);

        Console.WriteLine("The largest of the three numbers is: " + maximum);
    }

    private static int GetMax(int firstNum, int secondNum)
    {
        return Math.Max(firstNum, secondNum);
        //// other way
        //return (firstNum > secondNum) ? firstNum : secondNum;
    }

    //// other way - method with 3 parameters
    //static void Main()
    //{
    //    Console.Write("Enter first integer : ");
    //    int firstNum = int.Parse(Console.ReadLine());
    //    Console.Write("Enter second integer : ");
    //    int secondNum = int.Parse(Console.ReadLine());
    //    Console.Write("Enter third integer : ");
    //    int thirdNum = int.Parse(Console.ReadLine());

    //    int maximum = GetMax(firstNum, secondNum, thirdNum);

    //    Console.WriteLine("The largest of the three numbers is: " + maximum);

    //}

    //static int GetMax(int one, int two, int three)
    //{
    //    return Math.Max(Math.Max(one, two), three);
    //}

}