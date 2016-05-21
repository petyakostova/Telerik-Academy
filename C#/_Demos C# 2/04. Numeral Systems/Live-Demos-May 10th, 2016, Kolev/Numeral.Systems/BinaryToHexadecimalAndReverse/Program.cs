namespace BinaryToHexadecimalAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static Dictionary<char, string> HexBinaryTable = new Dictionary<char, string>()
        {
            {'0',"0000" },
            {'1',"0001" },
            {'2',"0010" },
            {'3',"0011" },
            {'4',"0100" },
            {'5',"0101" },
            {'6',"0110" },
            {'7',"0111" },
            {'8',"1000" },
            {'9',"1001" },
            {'A',"1010" },
            {'B',"1011" },
            {'C',"1100" },
            {'D',"1101" },
            {'E',"1110" },
            {'F',"1111" }
        };

        public static Dictionary<string, char> BinaryToHexTable = new Dictionary<string, char>()
        {
            {"0000", '0' },
            {"0001", '1' },
            {"0010", '2' },
            {"0011", '3' },
            {"0100", '4' },
            {"0101", '5' },
            {"0110", '6' },
            {"0111", '7' },
            {"1000", '8' },
            {"1001", '9' },
            {"1010", 'A' },
            {"1011", 'B' },
            {"1100", 'C' },
            {"1101", 'D' },
            {"1110", 'E' },
            {"1111", 'F' }
        };

        static void Main(string[] args)
        {
            var numberInHex = "1F4";
            var numberInBinary = HexadecimalToBinary(numberInHex);

            Console.WriteLine($"Original number: {numberInHex}");

            Console.WriteLine($"Hex to binary: {HexadecimalToBinary(numberInHex)}");
            Console.WriteLine($"Hex to binary (.NET): {HexadecimalToBinaryDOTNET(numberInHex)}");

            Console.WriteLine($"Binary to hex: {BinaryToHexadecimal(numberInBinary)}");
            Console.WriteLine($"Binary to hex (.NET): {BinaryToHexadecimalDOTNET(numberInBinary)}");
        }

        public static string HexadecimalToBinary(string number)
        {
            var builder = new StringBuilder();

            for (int i = 0; i < number.Length; i++)
            {
                var key = number[i];
                var value = HexBinaryTable[key];
                builder.Append(value);
            }

            return builder.ToString().PadLeft(32,'0');
        }

        public static string HexadecimalToBinaryDOTNET(string number)
        {
            // Hex to decimal
            var numberInDecimal = Convert.ToInt32(number, 16);

            // Decimal to binary
            var numberInBinary = Convert.ToString(numberInDecimal, 2);

            return numberInBinary.PadLeft(32, '0');
        }

        public static string BinaryToHexadecimal(string number)
        {
            var result = new StringBuilder();

            for (int i = 0; i < number.Length; i+=4)
            {
                var key = number.Substring(i, 4);
                var value = BinaryToHexTable[key];
                result.Append(value);
            }

            // Remove leading zeros and return number in hexadecimal form
            return result.ToString().TrimStart(new Char[] { '0' });
        }

        public static string BinaryToHexadecimalDOTNET(string number)
        {
            // Binary to decimal
            var numberInDecimal = Convert.ToInt32(number, 2);

            // Decimal to hex
            var numberInHex = Convert.ToString(numberInDecimal, 16);

            return numberInHex;
        }
    }
}
