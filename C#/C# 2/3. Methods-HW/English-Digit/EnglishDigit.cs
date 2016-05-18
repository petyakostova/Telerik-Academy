/*  3. English digit
    Write a method that returns the last digit of given integer as an English word. 
    Write a program that reads a number and prints the result of the method.
 */

using System;

class EnglishDigit
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        Console.WriteLine(GetDigit(inputNum));
    }

    private static string GetDigit(int inputNum)
    {
        string digitAsWord = null;

        string inputAsString = inputNum.ToString();

        switch (inputAsString[inputAsString.Length - 1])
        {
            case '0': digitAsWord = "zero"; break;
            case '1': digitAsWord = "one"; break;
            case '2': digitAsWord = "two"; break;
            case '3': digitAsWord = "three"; break;
            case '4': digitAsWord = "four"; break;
            case '5': digitAsWord = "five"; break;
            case '6': digitAsWord = "six"; break;
            case '7': digitAsWord = "seven"; break;
            case '8': digitAsWord = "eight"; break;
            case '9': digitAsWord = "nine"; break;
        }

        return digitAsWord;
    }

    // other way
    //static void Main()
    //{
    //    int inputNum = int.Parse(Console.ReadLine());

    //    Console.WriteLine((Digit)(inputNum % 10));
    //}

    //public enum Digit
    //{
    //    zero = 0,
    //    one = 1,
    //    two = 2,
    //    three = 3,
    //    four = 4,
    //    five = 5,
    //    six = 6,
    //    seven = 7,
    //    eight = 8,
    //    nine = 9
    //}

}