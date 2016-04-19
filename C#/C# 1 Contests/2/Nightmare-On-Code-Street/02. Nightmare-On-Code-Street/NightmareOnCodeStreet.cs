// 70/100 in bgcoder

using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string numberAsString = Console.ReadLine();

        long sum = 0;
        for (int i = 1; i < numberAsString.Length; i += 2)
        {
            if (numberAsString[i] != '-')
            {
                sum += numberAsString[i] - '0';
            }
        }

        Console.WriteLine("{0} {1}", numberAsString.Length / 2, sum);
    }
}