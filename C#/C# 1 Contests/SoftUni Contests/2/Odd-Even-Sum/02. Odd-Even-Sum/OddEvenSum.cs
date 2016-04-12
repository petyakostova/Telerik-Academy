using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long oddSum = 0;
        long evenSum = 0;

        for (int i = 1; i <= 2 * n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            if (i % 2 != 0)
            {
                oddSum += currentNum;
            }
            else
            {
                evenSum += currentNum;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}