namespace Calculation_Problem_AS
{
    using System;
    //using System.IO;
    using System.Linq;

    class CalculationProblemAS
    {
        public static void Main()
        {
            int numBase = 23;
            //new TestGenerator().GenerateTests(numBase);
            //return;

            string input = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] words = input.Split(' ').Take(numBase).ToArray();

            input = Console.ReadLine();
            words = input.Split(' ');
            int num = SumString(words, numBase);
            string res = ConvertNumberToString(num, numBase);
            Console.WriteLine("{0} = {1}", res, num);
        }

        private static int SumString(string[] words, int numBase)
        {
            int[] numbers = new int[words.Length];
            int result = 0;
            for (int i = 0; i < words.Length; i++)
            {
                numbers[i] = ConvertStringToNumber(words[i].ToLower(), numBase);
                //Console.WriteLine("{0} = {1}", ConvertNumberToString(numbers[i], numBase), numbers[i]);
                result += numbers[i];
            }
            return result;
        }

        private static int ConvertStringToNumber(string word, int numBase)
        {
            int num = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int digit = word[word.Length - 1 - i] - 'a';
                num += digit * (int)Math.Pow(numBase, i);
            }

            return num;
        }

        private static string ConvertNumberToString(int result, int numBase)
        {
            string resultStr = string.Empty;
            if (result == 0)
            {
                resultStr = "a";
            }

            while (result > 0)
            {
                char ch = (char)((result % numBase) + 'a');
                resultStr = ch.ToString() + resultStr;
                result /= numBase;
            }

            return resultStr;
        }

    }
}