/* 13. Decimal to Hexadecimal Number
   Using loops write a program that converts an integer number to its hexadecimal representation.
   The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.
   Input: On the first and only line you will receive an integer in the decimal numeral system.
   Output: On the only output line write the hexadecimal representation of the read number.
   Constraints: All numbers will always be valid 64-bit integers.                                      */

using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        //Console.WriteLine(decimalNumber.ToString("X"));
        //Console.WriteLine("{0:X}", decimalNumber);
        //Console.WriteLine(Convert.ToString(decimalNumber, 16).ToUpper());

        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string hexaNumber = "";   // other way: string hexaNumber = null;         
            while (decimalNumber > 0)
            {
                // must be long; when this type is int the result is wrong
                long checkRemainder = decimalNumber % 16;           
                string remainder = "";
                switch (checkRemainder)
                {
                    case 10: remainder = "A"; break;
                    case 11: remainder = "B"; break;
                    case 12: remainder = "C"; break;
                    case 13: remainder = "D"; break;
                    case 14: remainder = "E"; break;
                    case 15: remainder = "F"; break;
                    default: remainder = checkRemainder.ToString(); break;
                }
                hexaNumber = remainder + hexaNumber;
                decimalNumber /= 16;
            }

            Console.WriteLine(hexaNumber);
        }

    }
}