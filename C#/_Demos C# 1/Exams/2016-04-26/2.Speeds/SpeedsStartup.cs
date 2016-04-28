using System;

namespace Busses
{
    class SpeedsStartup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isFirst = true;
            int lastSpeed = -1;
            int speed = 0;

            int bestSum = 0;
            int bestLen = 0;

            int currentSum = 0;
            int currentLen = 0;

            bool isUpdated = false;

            for (int i = 0; i < n; i++)
            {
                speed = int.Parse(Console.ReadLine());
                isUpdated = false;
                if (isFirst)
                {
                    isFirst = false;
                    lastSpeed = speed;
                    currentLen = 1;
                    currentSum = speed;
                }
                else if (lastSpeed >= speed)
                {
                    lastSpeed = speed;
                    isUpdated = true;
                    if (currentLen > bestLen)
                    {
                        bestSum = currentSum;
                        bestLen = currentLen;
                    }
                    else if (currentLen == bestLen)
                    {
                        bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                    }
                    currentSum = speed;
                    currentLen = 1;
                }
                else
                {
                    ++currentLen;
                    currentSum += speed;
                }
            }

            if (!isUpdated)
            {
                if (currentLen > bestLen)
                {
                    bestSum = currentSum;
                    bestLen = currentLen;
                }
                else if (currentLen == bestLen)
                {
                    bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                }
            }

            Console.WriteLine(bestSum);
        }
    }
}
