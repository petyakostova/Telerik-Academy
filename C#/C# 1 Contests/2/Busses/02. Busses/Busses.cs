using System;

class Busses
{
    static void Main()
    {
        long numberBuses = long.Parse(Console.ReadLine());
        long groupSpeed = long.Parse(Console.ReadLine());

        int count = 1;

        for (int i = 1; i < numberBuses; i++)
        {
            long speedCurrent = long.Parse(Console.ReadLine());

            if (speedCurrent <= groupSpeed)
            {
                count++;
                groupSpeed = speedCurrent;
            }
        }

        Console.WriteLine(count);
    }
}