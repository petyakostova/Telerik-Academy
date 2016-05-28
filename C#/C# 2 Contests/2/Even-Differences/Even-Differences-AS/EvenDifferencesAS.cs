namespace Even_Differences_AS
{
    using System;

    class EvenDifferencesAS
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var numbersAsString = line.Split(' ');

            var numbers = new long[numbersAsString.Length];

            for (int j = 0; j < numbersAsString.Length; j++)
            {
                numbers[j] = int.Parse(numbersAsString[j]);
            }

            var answer = SumOfDifferences(numbers);

            Console.WriteLine(answer);
        }

        private static long SumOfDifferences(long[] numbers)
        {
            long sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                long diff = Math.Abs(numbers[i] - numbers[i - 1]);

                if (diff % 2 == 0)
                {
                    i++;
                    sum += diff;
                }
            }

            return sum;
        }

    }
}