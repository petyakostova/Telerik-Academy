using System;

public class ApplesOrangesOrBoth
{
    public static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (number < 0)
        {
            number = -number;
        }

        int oddDigitsSum = 0;
        int evenDigitsSum = 0;
        while (number > 0)
        {
            byte digit = (byte)(number % 10);
            if (digit % 2 == 0)
            {
                evenDigitsSum += digit;
            }
            else
            {
                oddDigitsSum += digit;
            }

            number /= 10;
        }

        int difference = evenDigitsSum - oddDigitsSum;
        if (difference > 0)
        {
            Console.WriteLine("apples {0}", evenDigitsSum);
        }
        else if (difference < 0)
        {
            Console.WriteLine("oranges {0}", oddDigitsSum);
        }
        else
        {
            Console.WriteLine("both {0}", evenDigitsSum);
        }
    }
}
