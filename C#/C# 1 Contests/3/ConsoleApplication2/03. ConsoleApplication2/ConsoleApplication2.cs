// 70/100 in bgcoder
namespace _03.ConsoleApplication2
{
    using System;
    using System.Numerics;

    class ConsoleApplication2
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int position = 0;
            BigInteger product = 1;
            BigInteger productAfter10 = 1;

            while (input != "END")
            {
                if (position % 2 == 0)
                {
                    BigInteger currentNumber = BigInteger.Parse(input);

                    if (currentNumber != 0 && position < 10)
                    {
                        while (currentNumber > 0)
                        {
                            if (currentNumber % 10 != 0)
                            {
                                product *= currentNumber % 10;
                            }                            
                            currentNumber /= 10;
                        }
                    }
                    else if (currentNumber != 0 && position >= 10)
                    {
                        while (currentNumber > 0)
                        {
                            if (currentNumber % 10 != 0)
                            {
                                productAfter10 *= currentNumber % 10;
                            }
                            currentNumber /= 10;
                        }
                    }
                }
                
                input = Console.ReadLine();
                position++;
            }

            Console.WriteLine(product);
            if (position > 9)
            {
                Console.WriteLine(productAfter10);
            }

        }
    }
}
