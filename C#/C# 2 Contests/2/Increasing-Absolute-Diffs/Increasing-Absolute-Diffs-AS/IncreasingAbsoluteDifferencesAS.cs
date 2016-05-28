namespace Increasing_Absolute_Diffs_AS
{
    using System;

    class IncreasingAbsoluteDifferencesAS
    {
        public static void Main()
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine();
                var numbersAsString = line.Split(' ');

                var numbers = new long[numbersAsString.Length];

                for (int j = 0; j < numbersAsString.Length; j++)
                {
                    numbers[j] = int.Parse(numbersAsString[j]);
                }

                var answer = IsIncreasing(numbers);

                Console.WriteLine(answer);
            }
        }

        private static bool IsIncreasing(long[] numbers)
        {
            if (numbers.Length <= 2)
            {
                return true;
            }

            long last = Math.Abs(numbers[1] - numbers[0]);

            for (int i = 2; i < numbers.Length; i++)
            {
                long diff = Math.Abs(numbers[i] - numbers[i - 1]);

                if (diff - last != 1 && diff - last != 0)
                {
                    return false;
                }

                last = diff;
            }

            return true;
        }

    }
}