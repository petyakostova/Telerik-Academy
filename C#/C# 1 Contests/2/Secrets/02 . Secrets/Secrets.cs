using System;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        BigInteger inputNumber = BigInteger.Parse(Console.ReadLine());
        BigInteger number = inputNumber;

        // important check for the negative numbers
        if (number < 0)
        {
            number = -number; 
        }

        BigInteger specialSum = 0;

        int i = 1;

        while (number > 0)
        {
            int digit = (int)(number % 10);
            if (i % 2 == 1)
            {
                specialSum += digit * (int)Math.Pow(i, 2);
            }
            else
            {
                specialSum += (int)Math.Pow(digit, 2) * i;
            }

            i++;
            number /= 10;
        }

        BigInteger lengthSequence = specialSum % 10;
        BigInteger remainder = specialSum % 26;

        Console.WriteLine(specialSum);
        if (lengthSequence == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", inputNumber);
        }
        else
        {
            int counter = 1;
            char letter = (char)(65 + (int)remainder);

            while (true)
            {
                if (counter > lengthSequence)
                {
                    break;
                }
                else
                {
                    Console.Write(letter);
                }

                if (letter == 'Z')
                {
                    letter = 'A';
                }
                else
                {
                    letter++;
                }
                counter++;
            }
        }

    }
}