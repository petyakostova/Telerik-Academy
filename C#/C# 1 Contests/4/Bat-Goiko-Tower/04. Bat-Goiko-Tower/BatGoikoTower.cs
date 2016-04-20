using System;

class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());

        // part 1
        Console.WriteLine("{0}/\\{0}", new string('.', height - 1));

        // part 2
        int dashPut = 0;
        int dashPutAfter = 2;
        for (int i = 0; i < height - 1; i++)
        {
            if (i == dashPut)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', height - 2 - i), new string('-', 2 + 2 * i));
                dashPut += dashPutAfter;
                dashPutAfter++;
            }
            else
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', height - 2 - i), new string('.', 2 + 2 * i));
            }
        }

    }
}