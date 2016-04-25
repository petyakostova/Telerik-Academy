using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int width = 2 * n + 1;

        // part 1
        for (int row = 0; row < n; row++)
        {
            Console.Write(new string('#', row) + "\\");

            int spaceLeft = width - 2 * row - 2 - 2 * d;
            if (spaceLeft >= 2) // because of line with new string('.', spaceLeft - 2) 
            // if (spaceLeft > 2) // this works too
            {
                Console.Write(new string(' ', d) + "\\");
                Console.Write(new string('.', spaceLeft - 2));
                Console.Write("/" + new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', width - 2 * row - 2));
            }

            Console.Write("/" + new string('#', row));

            Console.WriteLine();
        }

        // part 2 (middle line)
        Console.WriteLine(new string('#', n) + 'X' + new string('#', n));

        // part 3 - symmetric to part 1
        for (int row = n - 1; row >= 0; row--)
        {
            Console.Write(new string('#', row) + "/");

            int spaceLeft = width - 2 * row - 2 - 2 * d;
            if (spaceLeft >= 2) // because of line with new string('.', spaceLeft - 2)
            // if (spaceLeft > 2) // this works too
            {
                Console.Write(new string(' ', d) + "/");
                Console.Write(new string('.', spaceLeft - 2));
                Console.Write("\\" + new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', width - 2 * row - 2));
            }

            Console.Write("\\" + new string('#', row));

            Console.WriteLine();
        }

    }
}