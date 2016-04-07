using System;

class OddEvenSumAS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sumOdd = 0;
        int sumEven = 0;
        bool odd = true;

        for (int i = 0; i < 2 * n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            if (odd)
            {
                sumOdd = sumOdd + element;
            }
            else
            {
                sumEven = sumEven + element;
            }
            odd = !odd;
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("Yes, sum=" + sumOdd);
        }
        else
        {
            int diff = Math.Abs(sumOdd - sumEven);
            Console.WriteLine("No, diff=" + diff);
        }
    }
}