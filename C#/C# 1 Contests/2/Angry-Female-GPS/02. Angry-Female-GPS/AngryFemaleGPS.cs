using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());

        if (number < 0)
        {
            number = -number;
        }

        int evenSum = 0;
        int oddSum = 0;

        while (number > 0)
        {
            int digit = (int)(number % 10);
            if (digit % 2 == 0)
            {
                evenSum += digit;
            }
            else
            {
                oddSum += digit;
            }

            number /= 10;
        }

        if (evenSum > oddSum)
        {
            Console.WriteLine("right {0}", evenSum);
        }
        else if (oddSum > evenSum)
        {
            Console.WriteLine("left {0}", oddSum);
        }
        else
        {
            Console.WriteLine("straight {0}", evenSum);
        }
    }
}