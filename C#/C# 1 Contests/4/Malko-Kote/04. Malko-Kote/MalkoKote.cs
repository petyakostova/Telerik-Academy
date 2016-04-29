using System;

class MalkoKote
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char character = char.Parse(Console.ReadLine());

        //int height = size;
        int width = size / 2 + 4;
        int catBodyWidth = width / 2 + 1;

        // part 1
        Console.WriteLine("{0}{1}{2}{1}{3}",
            new string(' ', 1), new string(character, 1), new string(' ', catBodyWidth - 4), new string(' ', catBodyWidth));

        // part 2
        for (int i = 0; i < size / 4 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string(' ', 1), new string(character, catBodyWidth - 2), new string(' ', catBodyWidth));
        }

        // part 3
        for (int i = 0; i < size / 4 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string(' ', 2), new string(character, catBodyWidth - 4), new string(' ', catBodyWidth + 1));
        }

        // part 4 - like part 2
        for (int i = 0; i < size / 4 - 1; i++)
        {
            Console.WriteLine("{0}{1}{2}",
                new string(' ', 1), new string(character, catBodyWidth - 2), new string(' ', catBodyWidth));
        }

        // part 5
        Console.WriteLine("{0}{1}{2}{3}",
            new string(' ', 1), new string(character, catBodyWidth - 2),
            new string(' ', 3), new string(character, catBodyWidth - 3));

        // part 6
        for (int i = 0; i < size / 4 + 1; i++) //size / 4 - 1 + 2
        {
            Console.WriteLine("{0}{1}{2}{3}",
                new string(character, catBodyWidth), new string(' ', 2),
                new string(character, 1), new string(' ', width / 2 - 3));
        }

        // part 7
        Console.WriteLine("{0}{1}{2}{3}",
            new string(character, catBodyWidth), new string(' ', 1), new string(character, 2), new string(' ', width / 2 - 3));

        // part 8
        Console.WriteLine("{0}{1}{2}",
            new string(' ', 1), new string(character, catBodyWidth + 1),
            new string(' ', width - catBodyWidth - 2)); // width - 1 - (catBodyWidth + 1)

    }
}