using System;

namespace DecryptText
{
    public class SymbolToNumberSolution
    {
        public static void Main()
        {

            int salt = int.Parse(Console.ReadLine());
            for (int ch = Console.Read(), index = 0; ch != '@'; ch = Console.Read(), index++)
            {
                decimal encodedChar;
                if (('a' <= ch && ch <= 'z') ||
                    ('A' <= ch && ch <= 'Z'))
                {
                    encodedChar = ch * salt + 1000;
                }
                else if ('0' <= ch && ch <= '9')
                {
                    encodedChar = ch + salt + 500;
                }
                else
                {
                    encodedChar = ch - salt;
                }

                string toPrint;
                if (index % 2 == 0)
                {
                    encodedChar /= 100M;
                    toPrint = string.Format("{0:0.00}", encodedChar);
                }
                else
                {
                    encodedChar *= 100M;
                    toPrint = encodedChar + "";
                }
                Console.WriteLine(toPrint);
            }
        }
    }
}