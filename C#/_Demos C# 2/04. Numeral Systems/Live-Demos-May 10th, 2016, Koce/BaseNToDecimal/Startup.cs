namespace BaseNToDecimal
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static int BaseNToDecimal(string nValue, int radix, Dictionary<char, int> digitsToValues)
        {
            int sum = 0;

            foreach (char digit in nValue)
            {
                sum = digitsToValues[digit] + sum * radix;
            }

            return sum;
        }

        static void Main()
        {
            // converts a number in arbitary numeral system(with a positive radix) to it's decimal representation

            // first, the radix is read from the console
            int radix = int.Parse(Console.ReadLine());

            // after that, all digits are mapped to a decimal value
            var digitsToValues = new Dictionary<char, int>();

            for (int i = 0; i < radix; i++)
            {
                char digit = Console.ReadLine()[0];
                int value = int.Parse(Console.ReadLine());

                digitsToValues.Add(digit, value);
            }

            var numberToConvert = Console.ReadLine();

            int decimalValue = BaseNToDecimal(numberToConvert, radix, digitsToValues);

            Console.WriteLine(decimalValue);
        }
    }
}
