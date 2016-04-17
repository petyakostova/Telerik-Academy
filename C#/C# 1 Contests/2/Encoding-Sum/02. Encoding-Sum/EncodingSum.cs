namespace _02.Encoding_Sum
{
    using System;

    class EncodingSum
    {
        static void Main()
        {
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine().ToUpper();
            
            int i = 0;
            long result = 0;
            while (text[i] != '@')
            {
                if (Char.IsDigit(text[i]))
                {
                    result *= text[i] - '0';
                }
                else if (Char.IsLetter(text[i]))
                {
                    result += text[i] - 'A';
                }
                else
                {
                    result %= module;
                }

                i++;
            }

            Console.WriteLine(result);
        }
    }
}