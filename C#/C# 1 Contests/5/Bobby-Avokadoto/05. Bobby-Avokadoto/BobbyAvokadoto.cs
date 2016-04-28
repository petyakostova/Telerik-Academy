using System;

class BobiAvokadoto
{
    static void Main()
    {
        uint hair = uint.Parse(Console.ReadLine());
        uint combs = uint.Parse(Console.ReadLine());

        uint bestComb = 0;
        uint bestTeeths = 0;
        bool overlapp = false;

        for (int i = 0; i < combs; i++)
        {
            uint currComb = uint.Parse(Console.ReadLine());
            uint currHair = hair;
            uint currTeeths = 0;

            for (int p = 0; p < 32; p++)
            {
                // get the bit at position p in the comb
                long maskComb = 1 << p;
                long nAndMaskComb = currComb & maskComb;
                long bitComb = nAndMaskComb >> p;

                if (bitComb == 1)   // searching for the ones
                {
                    long maskHair = 1 << p;
                    long nAndMaskHair = currHair & maskHair;
                    long bitHair = nAndMaskHair >> p;

                    if (bitHair == 1)
                    {
                        overlapp = true;
                        break;
                    }
                    else
                    {
                        currTeeths++;
                    }
                }
            }

            if (!overlapp)
            {
                if (currTeeths > bestTeeths)
                {
                    bestComb = currComb;
                    bestTeeths = currTeeths;
                }
            }
            else
            {
                overlapp = false;
            }

        }

        Console.WriteLine(bestComb);
    }
}