// 80/100 in bgcoder

using System;

class SevenlandNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int nextNumber = 0;
        int count = 1;

        while (nextNumber <= number)
        {
            if (count % 7==0)
            {
                nextNumber += 4;
            }
            else
            {
                nextNumber++;
            }
            count++;
        }

        Console.WriteLine(nextNumber);
    }
}