using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //number or rounds

        int leftBeersMitko = 0;
        int rightBeersVladko = 0;

        for (int i = 0; i < n; i++)
        {
            // Read the number, skipping the leading zeroes
            int currentNum = int.Parse(Console.ReadLine());

            // Turn negative numbers to positive (remove the "-" sign)
            if (currentNum < 0)
            {
                currentNum *= -1;
            }

            // Count the digits in the drunken number
            int digitsCount = 0;
            int helpNum = currentNum;
            while (helpNum > 0)
            {
                digitsCount++;
                helpNum /= 10;
            }

            // check if the digits count is even 
            if (digitsCount % 2 == 0)
            {
                for (int r = 0; r < digitsCount / 2; r++)
                {
                    rightBeersVladko += currentNum % 10;
                    currentNum /= 10;
                }
                for (int l = 0; l < digitsCount / 2; l++)
                {
                    leftBeersMitko += currentNum % 10;
                    currentNum /= 10;
                }
            }
            else // if the digits count is odd
            {
                for (int r = 0; r <= digitsCount / 2; r++)
                {
                    rightBeersVladko += currentNum % 10;
                    if (r == digitsCount / 2)
                    {
                        // add the middle digit to Mitko's beers too
                        leftBeersMitko += currentNum % 10;
                    }
                    currentNum /= 10;
                }
                for (int l = 0; l < digitsCount / 2; l++)
                {
                    leftBeersMitko += currentNum % 10;
                    currentNum /= 10;
                }
            }
        }

        // printing the result
        if (leftBeersMitko == rightBeersVladko)
        {
            int totalDrunkenBeers = leftBeersMitko + rightBeersVladko;
            Console.WriteLine("No {0}", totalDrunkenBeers);
        }
        else if (leftBeersMitko > rightBeersVladko)
        {
            Console.WriteLine("M {0}", leftBeersMitko - rightBeersVladko);
        }
        else
        {
            Console.WriteLine("V {0}", rightBeersVladko - leftBeersMitko);
        }

    }
}