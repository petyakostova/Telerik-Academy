namespace HexadecimalToDecimalAndReverse
{
    using System;
    using System.Text;

    class Program
    {
        public const string HexadecimalAlphabet = "0123456789ABCDEF";

        static void Main(string[] args)
        {
            Console.WriteLine(HexadecimalToDecimal("1F4"));
            Console.WriteLine(HexadecimalToDecimal("FF"));

            Console.WriteLine(HexadecimalToDecimalDOTNET("1F4"));
            Console.WriteLine(HexadecimalToDecimalDOTNET("FF"));

            Console.WriteLine(DecimalToHexadecimal(500));
            Console.WriteLine(DecimalToHexadecimal(255));

            Console.WriteLine(DecimalToHexadecimalDOTNET(500));
            Console.WriteLine(DecimalToHexadecimalDOTNET(255));
        }

        public static int HexadecimalToDecimal(string number)
        {
            var digitValue = 0;
            var decimalNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A':
                        digitValue = 10;
                        break;
                    case 'B':
                        digitValue = 11;
                        break;
                    case 'C':
                        digitValue = 12;
                        break;
                    case 'D':
                        digitValue = 13;
                        break;
                    case 'E':
                        digitValue = 14;
                        break;
                    case 'F':
                        digitValue = 15;
                        break;
                    default:
                        digitValue = number[i] - 48;
                        break;
                }

                var exponent = number.Length - 1 - i;
                decimalNumber += digitValue * (int)Math.Pow(16, exponent);
            }

            return decimalNumber;
        }

        public static int HexadecimalToDecimalDOTNET(string number)
        {
            return Convert.ToInt32(number, 16);
        }

        public static string DecimalToHexadecimal(int number)
        {
            var builder = new StringBuilder();
            var remainder = 0;
            var hexNumberIdentifier = "0x";

            while (number != 0)
            {
                remainder = number % 16;
                builder.Insert(0, HexadecimalAlphabet[remainder]);
                number = number / 16;
            }

            builder.Insert(0, hexNumberIdentifier);

            return builder.ToString();
        }

        public static string DecimalToHexadecimalDOTNET(int number)
        {
            return "0x" + Convert.ToString(number, 16);
        }

        public static string Reverse(string sequence)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                builder.Append(sequence[i]);
            }

            return builder.ToString();
        }
    }
}
