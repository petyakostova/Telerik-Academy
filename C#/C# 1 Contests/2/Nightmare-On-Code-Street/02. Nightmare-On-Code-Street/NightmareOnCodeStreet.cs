using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string numberAsString = Console.ReadLine();

        int counterOfDigits = 0;
        int sum = 0;
        for (int i = 1; i < numberAsString.Length; i += 2)
        {
            if ('0' <= numberAsString[i] && numberAsString[i] <= '9')
            {
                sum += numberAsString[i] - '0';
                counterOfDigits++;
            }
        }

        Console.WriteLine("{0} {1}", counterOfDigits, sum);
    }
}