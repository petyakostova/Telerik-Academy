using System;

class SevenlandNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int nextNumber = 0;
        int count = 1;
        int pow = 1;

        while (nextNumber <= number)
        {
            if (nextNumber == 666)
            {
                nextNumber = 1000;
            }
            else if (count % 49 == 0)
            {
                nextNumber += 34;
                pow++;
            }
            else if (count % 7 == 0)
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