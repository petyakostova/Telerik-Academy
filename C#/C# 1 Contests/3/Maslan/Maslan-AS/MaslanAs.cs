using System;
using System.Numerics;

class MaslanAS
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
                if (position % 2 != 0)
                {
                    int number = symbol - '0';
                    sum += number;
                }

                if (sum > 0)
                {
                    product *= sum;
                }

                position++;
            }

            if (sum != 0)
            {
                product /= sum;
            }

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