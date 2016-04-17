// 80/100 in bgcoder
using System;
using System.Numerics;

class ConsoleApplication2AS
{
    static void Main()
    {
        int position = 0;
        string line = Console.ReadLine();

        BigInteger productOfFirstTen = 1;
        BigInteger productOfOthers = 1;

        bool hasTenNumbers = false;

        while (line != "END")
        {
            if (position % 2 == 0)
            {
                string currentNumber = line;
                BigInteger product = 1;

                foreach (var symbol in currentNumber)
                {
                    if (symbol != '0')
                    {
                        product *= symbol - '0';
                    }
                }

                if (hasTenNumbers)
                {
                    productOfOthers *= product;
                }
                else
                {
                    productOfFirstTen *= product;
                }
            }

            position++;

            if (position == 10)
            {
                hasTenNumbers = true;
            }

            line = Console.ReadLine();
        }

        if (hasTenNumbers)
        {
            Console.WriteLine(productOfFirstTen);
            Console.WriteLine(productOfOthers);
        }
        else
        {
            Console.WriteLine(productOfFirstTen);
        }
    }
}