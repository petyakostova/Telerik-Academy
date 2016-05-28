namespace _01.De_cat_coding
{
    using System;
    using System.Linq; // needed fot Select()

    class DeCatCoding
    {
        static void Main()
        {
            // read input
            string[] numbers = Console.ReadLine()
                .Split(' ') // extract all cat numbers from the input
                .Select(CatToDecimal) // convert all cat numbers to decimal
                .Select(DecimalTo26) // convert all decimal numbers to base 26
                .ToArray(); // put the numbers in one collection

            // other way with one Select()
            //var numbers = Console.ReadLine().Split(' ').Select(x => DecimalTo26(CatToDecimal(x))).ToArray();

            // medium check after Split()
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(CatToDecimal(num)); // 114674
            //}

            // join by space and print
            Console.WriteLine(string.Join(" ", numbers));
        }

        // convert cat number to decimal
        static ulong CatToDecimal(string catNumber)
        {
            ulong result = 0;

            // instead of calculating powers
            foreach (var digit in catNumber)
            {
                result = (ulong)(digit - 'a') + result * 21;
            }

            return result;
        }

        // convert decimal number to base 26
        static string DecimalTo26(ulong decNumber)
        {
            var result = string.Empty;

            do
            {
                char digitValue = (char)((decNumber % 26) + 'a');
                result = digitValue + result; // to be in reversed order
                decNumber /= 26;

            } while (decNumber > 0); // decNumber != 0

            return result;
        }

    }
}