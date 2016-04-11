using System;

public class NakovsMatchingAS
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();
        int maxDiff = int.Parse(Console.ReadLine());

        bool found = false;

        for (int firstIndex = 1; firstIndex <= firstStr.Length - 1; firstIndex++)
        {
            string leftFirstStr = firstStr.Substring(0, firstIndex); //public String Substring(int startIndex, int length);
            string rightFirstStr = firstStr.Substring(firstIndex); //public String Substring(int startIndex);
            int leftFirstWeight = SumChars(leftFirstStr);
            int rightFirstWeight = SumChars(rightFirstStr);

            for (int secondIndex = 1; secondIndex <= secondStr.Length - 1; secondIndex++)
            {
                string leftSecondStr = secondStr.Substring(0, secondIndex);
                string rightSecondStr = secondStr.Substring(secondIndex);
                int leftSecondWeight = SumChars(leftSecondStr);
                int rightSecondWeight = SumChars(rightSecondStr);

                int diff = Math.Abs(leftFirstWeight * rightSecondWeight - rightFirstWeight * leftSecondWeight);

                if (diff <= maxDiff)
                {
                    Console.WriteLine(
                        '(' + leftFirstStr + '|' + rightFirstStr + ") matches (" +
                        leftSecondStr + '|' + rightSecondStr + ") by " + diff + " nakovs");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    static int SumChars(string str)
    {
        int sum = 0;

        foreach (char ch in str)
        {
            sum += (int)ch;
        }

        return sum;
    }
}