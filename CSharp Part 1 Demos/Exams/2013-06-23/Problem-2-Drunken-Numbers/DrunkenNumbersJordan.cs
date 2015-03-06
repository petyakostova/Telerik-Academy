using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Vladko beers
        int rightDigitsSum = 0;

        // Mitko beers
        int leftDigitsSum = 0;

        for (int i = 0; i < n; i++)
        {
            int digitsCount = 0;

            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;
            int digit4 = 0;
            int digit5 = 0;
            int digit6 = 0;
            int digit7 = 0;
            int digit8 = 0;
            int digit9 = 0;

            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber < 0)
            {
                currentNumber *= -1;
            }

            while (currentNumber > 0)
            {
                digitsCount++;
                int remainder = currentNumber % 10;

                switch (digitsCount)
                {
                    case 1: digit1 = remainder; break;
                    case 2: digit2 = remainder; break;
                    case 3: digit3 = remainder; break;
                    case 4: digit4 = remainder; break;
                    case 5: digit5 = remainder; break;
                    case 6: digit6 = remainder; break;
                    case 7: digit7 = remainder; break;
                    case 8: digit8 = remainder; break;
                    case 9: digit9 = remainder; break;
                }

                currentNumber /= 10;
            }

            switch (digitsCount)
            {
                case 1:
                    rightDigitsSum += digit1;
                    leftDigitsSum += digit1;
                    break;
                case 2:
                    rightDigitsSum += digit1;
                    leftDigitsSum += digit2;
                    break;
                case 3:
                    rightDigitsSum += digit1 + digit2;
                    leftDigitsSum += digit2 + digit3;
                    break;
                case 4:
                    rightDigitsSum += digit1 + digit2;
                    leftDigitsSum += digit3 + digit4;
                    break;
                case 5:
                    rightDigitsSum += digit1 + digit2 + digit3;
                    leftDigitsSum += digit3 + digit4 + digit5;
                    break;
                case 6:
                    rightDigitsSum += digit1 + digit2 + digit3;
                    leftDigitsSum += digit4 + digit5 + digit6;
                    break;
                case 7:
                    rightDigitsSum += digit1 + digit2 + digit3 + digit4;
                    leftDigitsSum += digit4 + digit5 + digit6 + digit7;
                    break;
                case 8:
                    rightDigitsSum += digit1 + digit2 + digit3 + digit4;
                    leftDigitsSum += digit5 + digit6 + digit7 + digit8;
                    break;
                case 9:
                    rightDigitsSum += digit1 + digit2 + digit3 + digit4 + digit5;
                    leftDigitsSum += digit5 + digit6 + digit7 + digit8 + digit9;
                    break;
            }
        }

        int difference = leftDigitsSum - rightDigitsSum;
        if (difference > 0)
        {
            Console.WriteLine("M {0}", difference);
        }
        else if (difference < 0)
        {
            Console.WriteLine("V {0}", difference * -1);
        }
        else
        {
            Console.WriteLine("No {0}", rightDigitsSum + leftDigitsSum);
        }
    }
}
