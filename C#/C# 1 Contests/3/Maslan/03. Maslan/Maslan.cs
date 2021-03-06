﻿namespace _03.Maslan
{
    using System;
    using System.Numerics;

    class Maslan
    {
        static void Main()
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());

            int transformations = 0;
            BigInteger product = 1;

            while (true)
            {
                while (number > 0)
                {
                    number /= 10;

                    string numberAsString = number.ToString();
                    long sum = 0;
                    for (int i = 0; i < numberAsString.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sum += numberAsString[i] - '0';
                        }
                    }

                    if (sum != 0)
                    {
                        product *= sum;
                    }
                }

                transformations++;
                if (transformations < 10)
                {
                    number = product;

                    if (number < 10)
                    {
                        break;
                    }
                    else
                    {
                        product = 1;
                    }
                }
                else
                {
                    break;
                }
            }

            if (transformations < 10)
            {
                Console.WriteLine(transformations);
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine(product);
            }

        }
    }
}