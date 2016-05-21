namespace DecimalToHex
{
    using System;

    class Program
    {
        const string HexDigits = "0123456789ABCDEF";

        static string DecimalToHex(int decValue)
        {
            // better performance could be achieved by using indexing instead of concatanation
            string result = string.Empty;

            do
            {
                int value = decValue % 16;
                result = HexDigits[value] + result;
                decValue /= 16;

            } while (decValue != 0);

            return result;
        }

        static int HexDigitToDecimalValue(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return hexDigit - '0';
            }

            return char.ToLower(hexDigit) - 'a' + 10;
        }

        static void Main()
        {
            var inputNumber = int.Parse(Console.ReadLine());

            var hexValue = DecimalToHex(inputNumber);

            Console.WriteLine(hexValue);

            //foreach (var digit in HexDigits)
            //{
            //    Console.WriteLine(HexDigitToDecimalValue(digit));
            //}
        }
    }
}
