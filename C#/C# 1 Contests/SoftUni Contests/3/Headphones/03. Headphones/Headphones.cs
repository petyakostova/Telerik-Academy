using System;

class Headphones
{
    static void Main()
    {
        int diameter = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('-', diameter / 2), new string('*', diameter + 2)); // part 1

        for (int i = 0; i < diameter; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', diameter / 2), new string('-', diameter)); // part 2
        }

        for (int i = 0; i < diameter / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", 
                new string('-', diameter / 2 - 1 - i), new string('*', 3 + 2 * i), new string('-', diameter - 2 - 2 * i)); // part 3
        }

        for (int i = 0; i < diameter / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", 
                new string('-', 1 + i), new string('*', diameter - 2 - 2 * i), new string('-', 3 + 2 * i)); // part 4
        }
    }
}