namespace _01.Calculation_Problem
{
    using System;
    using System.Linq;

    class CalculationProblem
    {
        static void Main()
        {
            // read input
            var sum = Console.ReadLine()
                .Split(' ')
                .Select(CatToDec) // convert every number to it's decimal value
                .Sum(); // sum all the elements of the collection (all the numbers)

            // instead of this we use Sum()
            //var sum = 0;
            //foreach (var num in catNumbers)
            //{
            //    sum += num;
            //}

            // medium check after read input
            //Console.WriteLine(string.Join("\n", catNumbers));
            // medium check CatToDec
            //Console.WriteLine(CatToDec(catNumbers[0])); // mia => 6532

            // convert the sum to cat numeral systems
            var answer = DecToCat(sum) + " = " + sum;
            // print the result
            Console.WriteLine(answer);

        }

        static int CatToDec(string catNum)
        {
            int result = 0;

            // instead of calculating powers
            foreach (var digit in catNum)
            {
                result = (digit - 'a') + result * 23;
            }

            return result;
        }

        static string DecToCat(int decNum)
        {
            string result = string.Empty;

            do
            {
                char digit = (char)((decNum % 23) + 'a');
                result = digit + result;
                decNum /= 23;

            } while (decNum > 0); // decNum != 0

            return result;
        }

    }
}