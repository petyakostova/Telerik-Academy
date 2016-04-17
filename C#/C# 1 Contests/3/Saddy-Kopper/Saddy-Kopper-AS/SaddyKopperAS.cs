using System;
using System.Numerics;

class SaddyKopperAS
{
    static void Main()
    {
        string text = Console.ReadLine();

        int transformations = 0;
        bool transformed = true;
        while (text.Length > 1)
        {
            int sum = 0;
            BigInteger product = 1;
            int position = 0;
            foreach (var symbol in text)
            {
                if (position % 2 == 0)
                {
                    int number = symbol - '0';
                    sum += number;
                }

                product *= sum;
                position++;
            }

            product /= sum;
            transformations++;

            text = product.ToString();

            if (transformations == 10)
            {
                transformed = false;
                break;
            }
        }

        if (transformed)
        {
            Console.WriteLine(transformations);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}