namespace TRES4_Numbers_AS
{
    using System;
    using System.Collections.Generic; // List<string>

    class TRES4NumbersAS
    {
        const int TresNumFourDigitsCount = 9;

        static readonly string[] TresNumFourDigits = new string[TresNumFourDigitsCount]
        {
        "LON+",
        "VK-",
        "*ACAD",
        "^MIM",
        "ERIK|",
        "SEY&",
        "EMY>>",
        "/TEL",
        "<<DON"
        };

        static void Main()
        {
            Console.WriteLine(ConvertToTresNumFourNumber(ulong.Parse(Console.ReadLine())));
        }

        static string ConvertToTresNumFourNumber(ulong decimalNumber)
        {
            List<string> tresNumFourNumber = new List<string>();
            do
            {
                tresNumFourNumber.Add(TresNumFourDigits[decimalNumber % TresNumFourDigitsCount]);

                decimalNumber /= TresNumFourDigitsCount;
            }
            while (decimalNumber != 0);

            tresNumFourNumber.Reverse(); // Reversing the number to get the real value
            return string.Join(string.Empty, tresNumFourNumber);
        }

    }
}