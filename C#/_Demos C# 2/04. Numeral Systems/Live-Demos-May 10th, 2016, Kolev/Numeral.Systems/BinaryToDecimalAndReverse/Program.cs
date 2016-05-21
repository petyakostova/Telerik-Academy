namespace BinaryToDecimalAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static StringBuilder builder = new StringBuilder();

        static void Main(string[] args)
        {
            var number = 500;

            var numberInBinaryDOTNET = DecimalToBinaryDOTNET(number);
            var numberInBinaryCUSTOM = DecimalToBinary(number);

            var numberInDecimalDOTNET = BinaryToDecimalDOTNET(numberInBinaryDOTNET);
            var numberInDecimalCUSTOM = BinaryToDecimal(numberInBinaryCUSTOM);

            Console.WriteLine($"Original number in Decimal System: {number}");

            Console.WriteLine();
            Console.WriteLine($"Decimal to Binary (.NET Implementation): {numberInBinaryDOTNET}");
            Console.WriteLine($"Decimal to Binary (Custom Implementation): {numberInBinaryCUSTOM}");

            Console.WriteLine();
            Console.WriteLine($"Binary to Decimal (.NET Implementation): {numberInDecimalDOTNET}");
            Console.WriteLine($"Binary to Decimal (Custom Implementation): {numberInDecimalCUSTOM}");

            var timeWithDotNetImplementation = Benchmark(DecimalToBinaryDOTNET);
            var timeWithCustomImplementation = Benchmark(DecimalToBinary);
            Console.WriteLine();
            Console.WriteLine($"Time with .NET Implementation: {timeWithDotNetImplementation.ToString()}");
            Console.WriteLine($"Time with Custom Implementation: {timeWithCustomImplementation.ToString()}");
        }

        public static string DecimalToBinary(int decimalNumber)
        {
            var builder = new StringBuilder();
            var remainder = default(int);

            while (decimalNumber != 0)
            {
                remainder = decimalNumber % 2;
                builder.Insert(0, remainder);
                decimalNumber = decimalNumber / 2;
            }

            return builder.ToString();
        }

        public static string DecimalToBinaryDOTNET(int decimalNumber)
        {
            return Convert.ToString(decimalNumber, 2);
        }

        public static int BinaryToDecimalDOTNET(string binaryNumber)
        {
            return Convert.ToInt32(binaryNumber, 2);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            var numberInDecimal = 0;
            var fromBase = 2;
            var position = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if(binaryNumber[i] != '0')
                {
                    position = binaryNumber.Length - i - 1;
                    numberInDecimal += (int)Math.Pow(fromBase, position);
                }
            }

            return numberInDecimal;
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

        public static TimeSpan Benchmark(Func<int, string> methodToBeTested)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                methodToBeTested.Invoke(i);
            }
            stopwatch.Stop();

            return stopwatch.Elapsed;
        }
    }
}
