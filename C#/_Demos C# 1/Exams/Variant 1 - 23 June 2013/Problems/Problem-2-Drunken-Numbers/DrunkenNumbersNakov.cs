using System;

class DrunkenNumbersNakov
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
            // Read the number, skipping the leading zeroes
            int currentNumber = int.Parse(Console.ReadLine());

            // Turn negative numbers to positive (remove the "-" sign)
            if (currentNumber < 0)
            {
                currentNumber *= -1;
            }

            // Calculate the total number of digits
            int numberOfDigits = 0;
            int num = currentNumber;
            while (num != 0)
            {
                num = num / 10;
                numberOfDigits++;
            }

            // Sum of digits at the right side
            for (int right = 0; right < numberOfDigits / 2; right++)
            {
                int currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                rightDigitsSum += currentDigit;
            }

            if (numberOfDigits % 2 == 1)
            {
                // We have a middle digit --> add it to both sums
                int middleDigit = currentNumber % 10;
                leftDigitsSum += middleDigit;
                rightDigitsSum += middleDigit;
                currentNumber = currentNumber / 10;
            }

            // Sum of digits at the left side
            for (int left = 0; left < numberOfDigits / 2; left++)
            {
                int currentDigit = currentNumber % 10;
                currentNumber = currentNumber / 10;
                leftDigitsSum += currentDigit;
            }
        }

        // Print the results: winner and difference
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
