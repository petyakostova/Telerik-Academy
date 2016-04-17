namespace _02.Decoding
{
    using System;

    class Decoding
    {
        static void Main()
        {
            int saltNumber = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int i = 0;
            while (text[i] != '@')
            {
                long encodedValue;
                if (Char.IsLetter(text[i]))
                {
                    encodedValue = text[i] * saltNumber + 1000;
                }
                else if (Char.IsDigit(text[i]))
                {
                    encodedValue = text[i] + saltNumber + 500;
                }
                else
                {
                    encodedValue = text[i] - saltNumber;
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
}