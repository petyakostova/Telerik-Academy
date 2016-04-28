using System;

class Batman
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char character = char.Parse(Console.ReadLine());

        int whitespace = 0;
        int sign = 0;

        // part 1
        for (int i = 0; i < size / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(' ', 0 + i), new string(character, size - i), new string(' ', size));

            // preparation for part 2
            if (i == (size / 2 - 2))
            {
                whitespace = 0 + i;
                sign = size - i;
            }
        }

        // part 2
        Console.WriteLine("{0}{1}{2}{3} {3}{2}{1}{0}",
            new string(' ', ++whitespace), new string(character, --sign), new string(' ', (size - 3) / 2), character);

        // part 3
        for (int i = 0; i < size / 3; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string(' ', size / 2), new string(character, 2 * size + 1));
        }

        // part 4
        for (int i = 0; i < size / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string(' ', size + 1 + i), new string(character, size - 2 - 2 * i));
        }

    }
}