using System;

class SpyHard
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine()
            .ToLower()                                                              // lowercase
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);    // String.Split() returns array

        string message = string.Join("", input); // make it to one string without the intervals

        long result = 0;
        long currentSymbolCode = 0;

        for (int i = 0; i < message.Length; i++)
        {
            switch (message[i])
            {
                case 'a': currentSymbolCode = 1; break;
                case 'b': currentSymbolCode = 2; break;
                case 'c': currentSymbolCode = 3; break;
                case 'd': currentSymbolCode = 4; break;
                case 'e': currentSymbolCode = 5; break;
                case 'f': currentSymbolCode = 6; break;
                case 'g': currentSymbolCode = 7; break;
                case 'h': currentSymbolCode = 8; break;
                case 'i': currentSymbolCode = 9; break;
                case 'j': currentSymbolCode = 10; break;
                case 'k': currentSymbolCode = 11; break;
                case 'l': currentSymbolCode = 12; break;
                case 'm': currentSymbolCode = 13; break;
                case 'n': currentSymbolCode = 14; break;
                case 'o': currentSymbolCode = 15; break;
                case 'p': currentSymbolCode = 16; break;
                case 'q': currentSymbolCode = 17; break;
                case 'r': currentSymbolCode = 18; break;
                case 's': currentSymbolCode = 19; break;
                case 't': currentSymbolCode = 20; break;
                case 'u': currentSymbolCode = 21; break;
                case 'v': currentSymbolCode = 22; break;
                case 'w': currentSymbolCode = 23; break;
                case 'x': currentSymbolCode = 24; break;
                case 'y': currentSymbolCode = 25; break;
                case 'z': currentSymbolCode = 26; break;
                default:
                    currentSymbolCode = message[i]; break;
            }
            result += currentSymbolCode;
        }

        Console.Write(numeralSystem);
        Console.Write(message.Length);
        //Console.WriteLine(result); //for medium check

        switch (numeralSystem)
        {
            case 2:
            case 8:
            case 10:
            case 16: Console.Write(Convert.ToString(result, numeralSystem)); break;
            default:
                {
                    // convert to sexagesimal  
                    string other = DecimalToArbitrarySystem(result, numeralSystem); 
                    Console.Write(other);
                    break;
                }
        }
        Console.WriteLine();
    }

    public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
    {
        const int BitsInLong = 64;
        const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        if (radix < 2 || radix > Digits.Length)
            throw new ArgumentException("The radix must be >= 2 and <= " +
                Digits.Length.ToString());

        if (decimalNumber == 0)
            return "0";

        int index = BitsInLong - 1;
        long currentNumber = Math.Abs(decimalNumber);
        char[] charArray = new char[BitsInLong];

        while (currentNumber != 0)
        {
            int remainder = (int)(currentNumber % radix);
            charArray[index--] = Digits[remainder];
            currentNumber = currentNumber / radix;
        }

        string result = new String(charArray, index + 1, BitsInLong - index - 1);
        if (decimalNumber < 0)
        {
            result = "-" + result;
        }

        return result;
    }
}