// DynamicOptimization - methodology of solving problems

using System;

class DynamicOptimization
{
    static void Main()
    {
        int[] numbers = { 6, 2, 4, 5, 1, 7, 8 };

        int minNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (minNumber > numbers[i])
            {
                minNumber = numbers[i];
            }
        }

        Console.WriteLine(minNumber); //1

        string[] texts = { "6", "2", "4", "5", "1", "7", "8" };

        string minText = texts[0];

        for (int i = 1; i < texts.Length; i++)
        {
            if (string.Compare(minText, texts[i], false) > 0)
            {
                minText = texts[i];
            }
        }

        Console.WriteLine(minText); //1

    }
}