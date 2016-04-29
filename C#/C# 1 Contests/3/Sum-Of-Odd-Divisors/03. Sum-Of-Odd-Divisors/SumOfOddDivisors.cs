using System;

class SumOfOddDivisors
{
    static void Main()
    {
        int startInterval = int.Parse(Console.ReadLine());
        int endInterval = int.Parse(Console.ReadLine());
        long sum = 0;

        for (int i = startInterval; i <= endInterval; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0 && j % 2 != 0)
                {
                    sum += j;
                }
            }
        }

        Console.WriteLine(sum);
    }
}