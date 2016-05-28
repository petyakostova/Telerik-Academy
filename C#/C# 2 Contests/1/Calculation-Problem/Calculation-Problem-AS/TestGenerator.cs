namespace Calculation_Problem_AS
{
    using System;
    using System.IO;
    using System.Text;

    public class TestGenerator
    {
        private char[] digits;
        private int numBase;

        private const int MinWordCount = 1;
        private const int MaxWordCount = 10;

        private const int MinWordLength = 1;
        private const int MaxWordLength = 10;

        private const int NumTests = 10;

        private string filePath;
        public const string FileNamesFormat = "{0}test.{1:000}.in.txt";
        private static readonly Random Rand = new Random();

        public void GenerateTests(int numBase, string filePath = "../../Tests/")
        {
            this.filePath = filePath;
            if (!string.IsNullOrWhiteSpace(this.filePath) &&
                !Directory.Exists(this.filePath))
            {
                Directory.CreateDirectory(this.filePath);
            }

            this.numBase = numBase;
            this.digits = GenerateDigits(numBase);

            CreateTest(1, MinWordCount);
            CreateTest(2, MinWordCount);
            for (int i = 3; i <= NumTests - 2; i++)
                CreateTest(i, Rand.Next(MinWordCount, MaxWordCount) + 1);
            CreateTest(NumTests - 1, MaxWordCount);
            CreateTest(NumTests, MaxWordCount);
        }

        private void CreateTest(object testNumber, int wordCount)
        {
            int currMaxWordLength = (int)Math.Floor(Math.Log((int.MaxValue / wordCount), numBase));

            using (var sw = new StreamWriter(
                string.Format(FileNamesFormat, this.filePath, testNumber)))
            {
                string[] words = new string[wordCount];
                for (int i = 0; i < wordCount; i++)
                {
                    words[i] = GenerateWord(currMaxWordLength);
                }

                sw.WriteLine(string.Join(" ", words));
            }

            Console.WriteLine("Test {0} is ready!", testNumber);
        }

        private char[] GenerateDigits(int numBase)
        {
            char[] digits = new char[numBase];
            for (int i = 0; i < numBase; i++)
            {
                digits[i] = (char)('a' + i);
            }

            return digits;
        }

        private string GenerateWord(int currMaxWordLength)
        {
            StringBuilder sb = new StringBuilder();
            int wordLength = Rand.Next(MinWordLength, currMaxWordLength + 1);
            for (int i = 0; i < wordLength; i++)
            {
                int digitIndex;
                do
                {
                    digitIndex = Rand.Next(0, numBase);
                } while (i == 0 && digitIndex == 0);

                sb.Append(digits[digitIndex]);
            }

            return sb.ToString();
        }

    }
}