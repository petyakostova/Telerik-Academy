using System;

public class SequencesOfBitsAS
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int lastBit = -1;

        int maxSequenceOfZeroes = 0;
        int currentSequenceOfZeroes = 0;

        int maxSequenceOfOnes = 0;
        int currentSequenceOfOnes = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int p = 29; p >= 0; p--)
            {
                int mask = 1 << p;
                int numberAndMask = number & mask;
                int bit = numberAndMask >> p;

                if (bit == 1)
                {
                    if (lastBit == 1)
                    {
                        currentSequenceOfOnes++;
                    }
                    else
                    {
                        currentSequenceOfOnes = 1;
                    }

                    maxSequenceOfOnes = Math.Max(maxSequenceOfOnes, currentSequenceOfOnes);
                }
                else
                {
                    // bit == 0
                    if (lastBit == 0)
                    {
                        currentSequenceOfZeroes++;
                    }
                    else
                    {
                        currentSequenceOfZeroes = 1;
                    }

                    maxSequenceOfZeroes = Math.Max(maxSequenceOfZeroes, currentSequenceOfZeroes);
                }

                lastBit = bit;
            }
        }

        Console.WriteLine(maxSequenceOfOnes);
        Console.WriteLine(maxSequenceOfZeroes);
    }
}