using System;

class SymbolToNumber
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int i = 0;
        while (text[i] != '@')
        {
            long encodedValue;
            if (Char.IsLetter(text[i]))
            {
                encodedValue = text[i] * secretNumber + 1000;
            }
            else if (Char.IsDigit(text[i]))
            {
                encodedValue = text[i] + secretNumber + 500;
            }
            else
            {
                encodedValue = text[i] - secretNumber;
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("{0:F2}", encodedValue / 100.0);
            }
            else
            {
                Console.WriteLine(encodedValue * 100);
            }

            i++;
        }

    }
}