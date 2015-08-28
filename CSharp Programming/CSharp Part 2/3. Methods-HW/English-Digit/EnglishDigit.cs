/*  Problem 3. English digit
    Write a method that returns the last digit of given integer as an English word.
    Examples:
                input 	output
                512 	two
                1024 	four
                12309 	nine
 */

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int inputNum = int.Parse(Console.ReadLine());

        Console.WriteLine(GetDigit(inputNum));
    }

    private static string GetDigit(int inputNum)
    {
        string digitAsWord = null;

        string inputAsString = inputNum.ToString();

        switch (inputAsString[inputAsString.Length - 1])
        {
            case '0': digitAsWord = "Zero"; break;
            case '1': digitAsWord = "One"; break;
            case '2': digitAsWord = "Two"; break;
            case '3': digitAsWord = "Three"; break;
            case '4': digitAsWord = "Four"; break;
            case '5': digitAsWord = "Five"; break;
            case '6': digitAsWord = "Six"; break;
            case '7': digitAsWord = "Seven"; break;
            case '8': digitAsWord = "Eight"; break;
            case '9': digitAsWord = "Nine"; break;
        }
        return digitAsWord;
    }


    //// other way
    //static void Main()
    //{
    //    Console.Write("Enter an integer number: ");
    //    int inputNum = int.Parse(Console.ReadLine());

    //    Console.WriteLine((Digit)(inputNum % 10));
    //}

    //public enum Digit
    //{
    //    Zero = 0,
    //    One = 1,
    //    Two = 2,
    //    Three = 3,
    //    Four = 4,
    //    Five = 5,
    //    Six = 6,
    //    Seven = 7,
    //    Eight = 8,
    //    Nine = 9
    //}

}