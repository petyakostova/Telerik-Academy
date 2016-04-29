using System;

class Speed
{
    static void Main()
    {
        int carsNumber = int.Parse(Console.ReadLine());
        int firstSpeed = int.Parse(Console.ReadLine());

        int longestGroup = 1;
        int initialSpeedsSum = firstSpeed;

        int count = 1;

        int currentSpeedSum = firstSpeed;

        for (int i = 1; i < carsNumber; i++)
        {
            int currentSpeed = int.Parse(Console.ReadLine());

            if (currentSpeed > firstSpeed)
            {
                count++;
                currentSpeedSum += currentSpeed;

                if (count > longestGroup)
                {
                    longestGroup = count;
                    initialSpeedsSum = currentSpeedSum;                    
                }
                else if (count == longestGroup)
                {
                    if (currentSpeedSum > initialSpeedsSum)
                    {
                        initialSpeedsSum = currentSpeedSum;
                    }
                }
            }
            else
            {
                count = 1;
                firstSpeed = currentSpeed;
                currentSpeedSum = firstSpeed;
            }
        }

        Console.WriteLine(initialSpeedsSum);

    }
}