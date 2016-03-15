using System;

internal class BinaryDigits
{
    private static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int row = 0; row < 4; row++)
        {
            for (int bit = 15; bit >= 0; bit--)
            {
                bool isOne = ((1 << bit) & N) > 0;

                if (isOne)
                {
                    // The current bit is one
                    switch (row)
                    {
                        case 0:
                        case 2:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 3:
                            Console.Write("###");
                            break;
                    }
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                        case 3:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                            Console.Write("#.#");
                            break;
                    }
                }

                if (bit > 0)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}
