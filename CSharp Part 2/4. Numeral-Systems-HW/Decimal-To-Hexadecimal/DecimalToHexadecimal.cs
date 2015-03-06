/*  Problem 3. Decimal to hexadecimal
    Write a program to convert decimal numbers to their hexadecimal representation.
 */
/*  Notes: Examples for faster testing:
                        decimal 	    hexadecimal
                        254 	        FE
                        6883 	        1AE3
                        338583669684 	4ED528CBB4   
 */
using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long decimalNumber;
        Console.Write("Enter an integer number: ");
        while (!long.TryParse(Console.ReadLine(), out decimalNumber))       // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid input!");
            Console.Write("Enter an integer number: ");
        }

        if (decimalNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            string hexaNumber = "";                             // other way: string hexaNumber = null;         
            while (decimalNumber > 0)
            {
                long checkRemainder = (long)decimalNumber % 16; // must be long; when this type is int the result is wrong
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