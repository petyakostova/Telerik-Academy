namespace BinaryAndDecimal
{
    using System;

    class Startup
    {
        // slides:
        // https://rawgit.com/TelerikAcademy/CSharp-Part-2/master/Topics/04.%20Numeral-Systems/slides/index.html#/2/4

        static int BinaryToDecimal(string binary)
        {
            int sum = 0;

            foreach (char bit in binary)
            {
                sum = (bit - '0') + sum * 2;
            }

            return sum;
        }

        static string DecimalToBinary(int decValue)
        {
            // better performance could be achieved by using indexing instead of concatanation
            string binary = string.Empty;

            do
            {
                int bit = decValue % 2;
                binary = bit + binary;
                decValue /= 2;

                // the above instructions are equivalent to

                //int bit = decValue & 1; // get rightmost bit
                //binary = bit + binary; // append it
                //decValue >>= 1; // set the next bit at rightmost position

            } while (decValue != 0);

            return binary;
        }

        static void Main()
        {
            var binaries = new string[] { "1111", "10101", "11", "10001" };
            
            foreach (var bin in binaries)
            {
                Console.WriteLine(BinaryToDecimal(bin));
            }

            //var decimals = new int[] { 15, 21, 3, 17 };

            //foreach (var dec in decimals)
            //{
            //    Console.WriteLine(DecimalToBinary(dec));
            //}
        }
    }
}
