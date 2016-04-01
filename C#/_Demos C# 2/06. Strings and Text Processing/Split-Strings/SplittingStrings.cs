using System;

class SplittingStrings
{
    static void Main()
    {
        string text = "1   2  3   4  5   6";

        //split
        string[] numbersAsText = text.Split(new char[] {' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);
        // can be also new string[] {"pesho"}...

        //create array
        int[] numbers = new int[numbersAsText.Length];

        //parse
        for (int i = 0; i < numbersAsText.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsText[i]);
        }

        //print
        Console.WriteLine(string.Join(" ", numbers));
    }
}