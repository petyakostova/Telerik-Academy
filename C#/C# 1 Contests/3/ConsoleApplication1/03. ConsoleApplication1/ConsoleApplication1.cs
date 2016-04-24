namespace _03.ConsoleApplication1
{
    using System;
    using System.Numerics;

    class ConsoleApplication1
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int position = 0;
            BigInteger product10 = 1;
            BigInteger productAfter10 = 1;

            while (input != "END")
            {
                if (position % 2 != 0 && input != "0")
                {
                    BigInteger currentNumber = BigInteger.Parse(input);

                    BigInteger product = 1;
                    while (currentNumber > 0)
                    {
                        if (currentNumber % 10 != 0)
                        {
                            product *= currentNumber % 10;
                        }
                        currentNumber /= 10;
                    }

                    if (position < 10)
                    {
                        product10 *= product;
                    }
                    else //if (position >= 10)
                    {
                        productAfter10 *= product;
                    }
                }

                input = Console.ReadLine();
                position++;
            }

            Console.WriteLine(product10);
            if (position > 9)
            {
                Console.WriteLine(productAfter10);
            }
        }
    }
}