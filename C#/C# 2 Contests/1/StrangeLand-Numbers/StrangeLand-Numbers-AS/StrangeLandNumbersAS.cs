namespace StrangeLand_Numbers_AS
{
    using System;

    class StrangeLandNumbersAS
    {
        const int StrangeLandDigitsCount = 7;
        const char LatinAlphabetFirstLetterLowercase = 'a';
        const char LatinAlphabetLastLetterLowercase = 'z';

        static readonly string[] StrangeLandDigits = new string[StrangeLandDigitsCount]
        {
        "f",
        "bIN",
        "oBJEC",
        "mNTRAVL",
        "lPVKNQ",
        "pNWE",
        "hT",
        };

        static void Main()
        {
            Console.WriteLine(ConvertToDecimal(Console.ReadLine()));
        }

        static long ConvertToDecimal(string strangeLandNumber)
        {
            long result = 0;

            int lastDigitStartIndex = strangeLandNumber.Length;
            int currentPower = 0;
            for (int index = strangeLandNumber.Length - 1; index >= 0; index--)
            {
                if (LatinAlphabetFirstLetterLowercase <= strangeLandNumber[index] && strangeLandNumber[index] <= LatinAlphabetLastLetterLowercase)
                {
                    string strangeLandDigit = strangeLandNumber.Substring(index, lastDigitStartIndex - index);

                    int currentDecimalDigit = Array.IndexOf(StrangeLandDigits, strangeLandDigit);

                    result += currentDecimalDigit * GetPower(StrangeLandDigitsCount, currentPower);

                    lastDigitStartIndex = index;
                    currentPower++;
                }
            }

            return result;
        }

        static long GetPower(int @base, int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= @base;
            }

            return result;
        }

    }
}
