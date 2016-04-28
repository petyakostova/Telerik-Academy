namespace Symbol.To.Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            // Scan char by char

            // If char is @ => exit program;
            // If char is letter = > result = ascii(letter) * SECRET + 1000
            // If char is digit => result = ascii(digit) + SECRET + 500
            // Else ==> result = ascii(char) - SECRET

            // If char is on even position => result /= 100
            // If chas is on odd position => result *= 100;

            // Repeat for each symbol in the text

            int secretNumber = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            double result = default(double);

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (currentSymbol == '@')
                {
                    return;
                }
                else if ((currentSymbol >= 'A' && currentSymbol <= 'Z') ||
                    (currentSymbol >= 'a' && currentSymbol <= 'z'))
                {
                    result = ((currentSymbol - 0) * secretNumber) + 1000;
                }
                else if ((currentSymbol >= '0' && currentSymbol <= '9'))
                {
                    result = ((currentSymbol - 0) + secretNumber) + 500;
                }
                else
                {
                    result = (currentSymbol - 0) - secretNumber;
                }

                if (i % 2 == 0)
                {
                    result /= 100;
                    Console.WriteLine("{0:F2}", result);
                }
                else
                {
                    result *= 100;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
