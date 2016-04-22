/* Note that zeroes could also take part in the play and 
the leading digits are lost after each rotation: 123400 -> 4123  */

using System;

class TripleRotationОfDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (0 < number && number < 10)
        {
            Console.WriteLine(number);
        }
        else if (9 < number && number < 100)
        {
            if (number % 10 != 0)
            {
                Console.WriteLine("{0}{1}", number % 10, number / 10);
            }
            else
            {
                Console.WriteLine(number / 10);
            }
        }
        else if (99 < number && number < 1000)
        {
            int digit1 = number / 100;
            int digit2 = number / 10 % 10;
            int digit3 = number % 10;

            if (digit2 == 0 && digit3 == 0)
            {
                Console.WriteLine(digit1);
            }
            else if (digit2 == 0)
            {
                Console.WriteLine("{0}{1}", digit1, digit3);
            }
            else if (digit3 == 0)
            {
                Console.WriteLine("{0}{1}", digit1, digit2);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}", digit1, digit2, digit3);
            }
        }
        else
        {
            int firstDigits = number / 1000;
            int last3Digits = number % 1000;
            int digit1 = last3Digits / 100;
            int digit2 = last3Digits / 10 % 10;
            int digit3 = last3Digits % 10;

            if (digit1 == 0 && digit2 == 0 && digit3 == 0)
            {
                Console.WriteLine(firstDigits);
            }
            else if (digit1 == 0 && digit2 == 0)
            {
                Console.WriteLine("{0}{1}", digit3, firstDigits);
            }
            else if (digit1 == 0 && digit3 == 0)
            {
                Console.WriteLine("{0}{1}", digit2, firstDigits);
            }
            else if (digit2 == 0 && digit3 == 0)
            {
                Console.WriteLine("{0}{1}", digit1, firstDigits);
            }
            else if (digit1 == 0)
            {
                Console.WriteLine("{0}{1}{2}", digit2, digit3, firstDigits);
            }
            else if (digit2 == 0)
            {
                Console.WriteLine("{0}{1}{2}", digit1, digit3, firstDigits);
            }
            else if (digit3 == 0)
            {
                Console.WriteLine("{0}{1}{2}", digit1, digit2, firstDigits);
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{3}", digit1, digit2, digit3, firstDigits);
            }
        }

    }
}