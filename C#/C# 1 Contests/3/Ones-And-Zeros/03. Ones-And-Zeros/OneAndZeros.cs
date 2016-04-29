using System;

class OneAndZeros
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string numberBinary = Convert.ToString(number, 2).PadLeft(32, '0');

        // print line 1
        for (int i = 16; i < 32; i++)
        {
            if (numberBinary[i] == '0')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write(".#.");
            }

            if (i != 31)
            {
                Console.Write(".");

            }
        }
        Console.WriteLine();

        // print line 2
        for (int i = 16; i < 32; i++)
        {
            if (numberBinary[i] == '0')
            {
                Console.Write("#.#");
            }
            else
            {
                Console.Write("##.");
            }

            if (i != 31)
            {
                Console.Write(".");

            }
        }
        Console.WriteLine();

        // print line 3 & 4
        for (int i = 0; i < 2; i++)
        {
            for (int j = 16; j < 32; j++)
            {
                if (numberBinary[j] == '0')
                {
                    Console.Write("#.#");
                }
                else
                {
                    Console.Write(".#.");
                }

                if (j != 31)
                {
                    Console.Write(".");

                }
            }
            Console.WriteLine();
        }

        // print line 5
        for (int i = 16; i < 32; i++)
        {
            Console.Write("###");

            if (i != 31)
            {
                Console.Write(".");
            }
        }

    }
}