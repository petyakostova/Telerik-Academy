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





        }
    }
}