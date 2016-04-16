using System;

class TripleRotationОfDigitsAS
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        for (int count = 1; count <= 3; count++)
        {
            if (k >= 10)
            {
                int lastDigit = k % 10;
                int firstDigits = k / 10;
                k = int.Parse("" + lastDigit + firstDigits);
            }
        }
        Console.WriteLine(k);
    }
}