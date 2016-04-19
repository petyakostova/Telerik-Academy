using System;

class ANacci
{
    static void Main()
    {
        char firstEl = char.Parse(Console.ReadLine());
        char secondEl = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());

        char nextEl = (char)(firstEl + secondEl - 64); //(firstEl - 64 + secondEl - 64) + 64
        if (firstEl - 64 + secondEl - 64 > 26) // > 'Z'
        {
            nextEl = (char)(((firstEl - 64 + secondEl - 64) % 26) + 64);
        }

        // print the first line
        Console.WriteLine(firstEl);

        // print the second line
        if (lines >= 2)
        {
            Console.WriteLine("{0}{1}", secondEl, nextEl);
            firstEl = secondEl;
            secondEl = nextEl;
        }

        // print the rest lines
        if (lines > 2)
        {
            for (int i = 1; i <= lines - 2; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if (firstEl - 64 + secondEl - 64 <= 26)
                    {
                        nextEl = (char)(firstEl + secondEl - 64); //(firstEl - 64 + secondEl - 64) + 64
                    }
                    else // > 'Z'
                    {
                        nextEl = (char)(((firstEl - 64 + secondEl - 64) % 26) + 64);
                    }

                    Console.Write(nextEl);

                    firstEl = secondEl;
                    secondEl = nextEl;

                    if (j != 2)
                    {
                        Console.Write(new string(' ', i));
                    }
                }
                Console.WriteLine();
            }
        }

    }
}