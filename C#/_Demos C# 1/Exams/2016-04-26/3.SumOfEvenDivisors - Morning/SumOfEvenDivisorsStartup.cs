using System;

namespace NumberOfDigitsMorning
{
    class SumOfEvenDivisorsMorningStartup
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sumOfDivisors = 0;

            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j % 2 == 0)
                    {
                        sumOfDivisors += j;
                    }
                }
            }

            Console.WriteLine(sumOfDivisors);
        }
    }
}
