using System;
using System.Text;

class SpyHard
{
    static void Main(string[] args)
    {
        int baseOfSystem = int.Parse(Console.ReadLine());
        Console.Write(baseOfSystem);

        string message = Console.ReadLine().ToLower();
        Console.Write(message.Length);

        int symbolSum = 0;

        for (int i = 0; i < message.Length; i++)
        {
            char currentSymbol = message[i];

            if (currentSymbol >= 'a' && currentSymbol <= 'z')
            {
                symbolSum += currentSymbol - 'a' + 1;
            }
            else
            {
                symbolSum += currentSymbol;
            }
        }

        StringBuilder numeralSystemConverter = new StringBuilder();

        while (symbolSum > 0)
        {
            numeralSystemConverter.Insert(0, symbolSum % baseOfSystem);
            symbolSum /= baseOfSystem;
        }

        Console.WriteLine(numeralSystemConverter);
    }
}