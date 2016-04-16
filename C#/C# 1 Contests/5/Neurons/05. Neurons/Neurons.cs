using System;

class Neurons
{
    static void Main()
    {
        while (true)
        {
            long line = long.Parse(Console.ReadLine());

            // -1 is the end
            if (line == -1)
            {
                break;
            }

            // we will need the indexes of the most left and most right one
            int mostLeftIndex = -1;
            int mostRightIndex = -1;

            for (int p = 0; p < 32; p++)
            {
                // get the bit at position p in the number line
                long mask = 1 << p;
                long nAndMask = line & mask;
                long bit = nAndMask >> p;

                if (bit == 1)   // searching for the ones
                {
                    if (mostRightIndex == -1)   // assure that's the first meeting
                    {
                        mostRightIndex = p;
                    }
                    mostLeftIndex = p;  // that will change and will remain te most left one
                }
            }

            if (mostLeftIndex == -1)    // there isn't any ones => the number is 0
            {
                Console.WriteLine(0);
                continue;
            }

            long result = 0;

            for (int p = mostRightIndex; p <= mostLeftIndex; p++)
            {
                // take the bit in the original number
                long mask = 1 << p;
                long nAndMask = line & mask;
                long bit = nAndMask >> p;

                // set the bits, which are 0s to 1s
                if (bit == 0)
                {
                    result = result | mask;
                }
            }

            Console.WriteLine(result);
        }

    }
}