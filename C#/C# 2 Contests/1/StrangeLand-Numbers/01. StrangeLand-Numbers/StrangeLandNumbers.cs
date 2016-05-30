namespace _01.StrangeLand_Numbers
{
    using System;
    using System.Numerics;

    class StrangeLandNumbers
    {
        // Math.Pow works slowly and it's unreliable for integer numbers so:
        static BigInteger Power(int number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        static void Main()
        {
            /* public String Replace(String oldValue, String newValue);
            Returns a new string in which all occurrences of a specified string in the current instance 
            are replaced with another specified string.*/
            string strangeNumber = Console.ReadLine()
                .Replace("f", "0")
                .Replace("bIN", "1")
                .Replace("oBJEC", "2")
                .Replace("mNTRAVL", "3")
                .Replace("lPVKNQ", "4")
                .Replace("pNWE", "5")
                .Replace("hT", "6");
            
            int power = 0;

            BigInteger result = 0;

            for (int i = strangeNumber.Length - 1; i >= 0; i--)
            {
                int currentNumber = strangeNumber[i] - '0'; // converting from char to int

                result += currentNumber * Power(7, power);
                power++;
            }

            Console.WriteLine(result);
        }

    }
}