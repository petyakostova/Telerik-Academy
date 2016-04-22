// 60/100 in bgcoder

using System;

class OneAndZeros
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string numberBinary = Convert.ToString(number, 2).PadLeft(16, '0');

        // print line 1
        for (int i = 0; i < numberBinary.Length; i++)
        {
            if (numberBinary[i] == '0')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write(".#.");
            }

            if (i != numberBinary.Length - 1)
            {
                Console.Write(".");

            }
        }
        Console.WriteLine();

        // print line 2
        for (int i = 0; i < numberBinary.Length; i++)
        {
            if (numberBinary[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write("##.");
            }

            if (i != numberBinary.Length - 1)
            {
                Console.Write(".");

            }
        }
        Console.WriteLine();

        // print line 3 & 4
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < numberBinary.Length; j++)
            {
                if (numberBinary[j] == '0')
                {
                    Console.Write("#.#");
                }
                else
                {
                    Console.Write(".#.");
                }

                if (j != numberBinary.Length - 1)
                {
                    Console.Write(".");

                }
            }
            Console.WriteLine();
        }

        // print line 5
        for (int i = 0; i < numberBinary.Length; i++)
        {
            Console.Write("###");

            if (i != numberBinary.Length - 1)
            {
                Console.Write(".");
            }
        }

    }
}