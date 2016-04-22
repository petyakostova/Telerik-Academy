// 70/100 in bgcoder

using System;

class TheHorror
{
    static void Main()
    {
        string numberAsString = Console.ReadLine();

        int sum = 0;
        int count = 0;
        for (int i = 0; i < numberAsString.Length; i += 2)
        {
            if ('0' <= numberAsString[i] && numberAsString[i] <= '9')
            {
                sum += numberAsString[i] - '0';
                count++;
            }
        }

        Console.WriteLine("{0} {1}", count, sum);

    }
}