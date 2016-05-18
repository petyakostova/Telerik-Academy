/*  7. One system to any other
    Write a program to convert the number N 
    from any numeral system of given base s to any other numeral system of base d.
    Input: On the first line you will receive the number s.
           On the second line you will receive a number in base s - N. There will not be leading zeros
           On the third line you will receive the number d
    Output: Print N in base d. There should not be leading zeros. Use uppercase letters
    Constraints: 2 <= s, d <= 16;       1 <= N <= 1018
    Sample tests:
                    Input 	    Output
                    13          21
                    16
                    9 	                    */

using System;
using System.Linq;

class OneSystemToAnyOther
{
    static void Main()
    {
        int baseX;
        Console.Write("Enter the base (of the numeral system)\n of the number You want to convert in the range [2.. 16]: ");
        // parsing and input check (validating the user data)
        while (!int.TryParse(Console.ReadLine(), out baseX) || baseX < 2 || baseX > 16)   
        {
            Console.WriteLine("Invalid base!");
            Console.Write("Enter a base in the range [2.. 16]: ");
        }
        Console.Write("\nEnter a number [base {0}]: ", baseX);
        string number = StringParse();

        int baseY;
        Console.Write("\nEnter to which base You want to convert the number {0}: ", number);
        while (!int.TryParse(Console.ReadLine(), out baseY) || baseX < 2 || baseX > 16)
        {
            Console.WriteLine("Invalid base!");
            Console.Write("Enter a base in the range [2.. 16]: ");
        }        

        string result = ConvertFromDecimalToBaseY(ConvertToDecimal(number.ToArray(), baseX), baseY);

        if (IsValidInput(number, result, baseX, baseY))
        {
            Console.Write("\n{0} [base {1}] converted to [base {2}] => {3}\n\n", number, baseX, baseY, result);
        }
        else
        {
            Console.WriteLine("\nYou have entered an invalid number!\n");
        }
    }

    #region Conversion
    // Convert number [base X] to number [base 10]
    static int ConvertToDecimal(char[] number, int baseX)
    {
        int result = 0;
        for (int i = number.Length - 1, pow = 1; i >= 0; i--, pow *= baseX)
            result += (number[i] >= 'A') ? (number[i] - 'A' + 10) * pow : (number[i] - '0') * pow;
        return result;
    }

    // Convert number [base 10] to number [base Y]
    static string ConvertFromDecimalToBaseY(int number, int baseY)
    {
        string result = string.Empty;
        while (number > 0)
        {
            int remainder = number % baseY;
            result = remainder >= 10 ? (char)('A' + remainder - 10) + result : remainder + result;
            number /= baseY;
        }
        return result;
    }
    #endregion

    #region Check
    static string StringParse()
    {
        string number = Console.ReadLine();
        // Check for incorrect number
        if (number.Any(t => t < 'A' && t > 'Z' && t < 'a' && t > 'z' && t < '0' && t > '9'))
        {
            throw new ArgumentException();
        }
        number = MakeAllLettersLarge(number);
        return number;
    }

    // To Upper => valid input number
    static string MakeAllLettersLarge(string number)
    {
        char[] digits = number.ToArray();

        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = char.ToUpper(number[i]);
        }
            
        return string.Join("", digits);
    }

    // Convert the result from BaseY to baseX and compare the new result with the old result (baseX to baseY)
    static bool IsValidInput(string number, string result, int baseX, int baseY)
    {
        return String.CompareOrdinal(ConvertFromDecimalToBaseY(ConvertToDecimal(result.ToArray(), baseY), baseX), number) == 0;
    }
    #endregion
}