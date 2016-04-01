/* 8. Digit as Word
   Write a program that read a digit (0-9) from the console and shows the digit as a word (in English).
   Print "not a digit" in case of invalid input. Use a switch statement.
   The input will never be an empty line. */

using System;

class DigitAsWord
{
    static void Main()
    {
        string digit = Console.ReadLine();

        switch (digit)
        {
            case "0":
                Console.WriteLine("zero");
                break;
            case "1":
                Console.WriteLine("one");
                break;
            case "2":
                Console.WriteLine("two");
                break;
            case "3":
                Console.WriteLine("three");
                break;
            case "4":
                Console.WriteLine("four");
                break;
            case "5":
                Console.WriteLine("five");
                break;
            case "6":
                Console.WriteLine("six");
                break;
            case "7":
                Console.WriteLine("seven");
                break;
            case "8":
                Console.WriteLine("eight");
                break;
            case "9":
                Console.WriteLine("nine");
                break;
            default:
                Console.WriteLine("not a digit");
                break;
        }
    }
}