namespace _02.Increasing_Absolute_Diffs
{
    using System;
    using System.Linq;

    class IncreasingAbsoluteDifferences
    {
        static void Main()
        {
            // the biggest abs diff is 2 000 000 000 - (-2 000 000 000) = 4 000 000 000 => long

            // 1. read sequences count
            var t = int.Parse(Console.ReadLine()); // sequences count

            // 2. for every sequence do the following
            for (int i = 0; i < t; i++)
            {
                // 1. read input
                var sequence = Console.ReadLine()
                    .Split(' ')
                    .Select(long.Parse)
                    .ToArray(); // put the input numbers in an array

                bool isIncreasing = true;

                for (int j = 2; j < sequence.Length; j++)
                {
                    // 2.1. calculate sequence of absolute differences
                    var previousAbsDiff = Math.Abs(sequence[j - 2] - sequence[j - 1]);
                    var currentAbsDiff = Math.Abs(sequence[j - 1] - sequence[j]);

                    // 2.2. check if the absolute differences sequence is not increasing
                    if (previousAbsDiff > currentAbsDiff 
                        || currentAbsDiff - previousAbsDiff > 1)
                    {
                        isIncreasing = false;
                        break;
                    }                    
                }

                // 2.3. output the result for the current sequence
                Console.WriteLine(isIncreasing);
            }

        }
    }
}