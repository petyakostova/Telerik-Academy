namespace _02.Even_Differences
{
    using System;
    using System.Linq;

    class EvenDifferences
    {
        static void Main()
        {
            // the biggest abs diff is 2 000 000 000 - (-2 000 000 000) = 4 000 000 000 => long

            // 1. read input
            var sequence = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray(); // 2. put the input numbers in an array

            long sum = 0;
            int i = 1;
            // 3. iterate over the array and calculate the sum
            while (i < sequence.Length)
            {
                // 3.1 find absolute difference of current and previous
                long absDiff = Math.Abs(sequence[i] - sequence[i - 1]);

                // 3.2 if even difference, sum it
                if (absDiff % 2 == 0)
                {
                    // sum even abs difference
                    sum += absDiff;
                    // 3.3 make even jump
                    i += 2;
                }
                else // if odd
                {
                    // 3.3 make odd jump
                    i++;
                }
            }

            // 4. print the sum
            Console.WriteLine(sum);

        }
    }
}