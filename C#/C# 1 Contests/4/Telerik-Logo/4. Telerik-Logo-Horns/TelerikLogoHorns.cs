using System;

class TelerikLogoHorns
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        //int y = x;
        int z = x / 2 + 1;

        int width = (2 * x + 2 * z) - 3;
        // height = width; //3 * x - 3

        Console.WriteLine("{0}*{1}*{0}", new string('.', z - 1), new string('.', width - 2 * z)); // part 1

        int dotsBeforeHorn = z - 2; // x / 2 - 1
        int dotsAfterHorn = 0;
        int middleDots = width - 2 * z - 2;
        for (int i = 1; i <= x - 2; i++)
        {
            // check if the row is with horns for part 2-1
            if (i < z) // i <= x / 2
            {
                Console.Write("{0}*{1}", new string('.', dotsBeforeHorn), new string('.', dotsAfterHorn));
                //dotsBeforeHorn and dotsAfterHorn will be updated after print the right horn
            }
            else
            {
                Console.Write(new string('.', z - 1)); //z = x / 2 + 1;
            }

            // part 2-2
            Console.Write("{0}*{1}*{0}",
                new string('.', i), new string('.', middleDots)); 
            middleDots -= 2;

            // check if the row is with horns for part 2-3
            if (i < z) // i <= x / 2
            {
                Console.WriteLine("{0}*{1}", new string('.', dotsAfterHorn), new string('.', dotsBeforeHorn));
                dotsBeforeHorn--;
                dotsAfterHorn++;
            }
            else
            {
                Console.WriteLine(new string('.', z - 1)); //z = x / 2 + 1;
            }
        }

        Console.WriteLine("{0}*{0}", new string('.', z + x - 2)); // part 3

        for (int i = 0; i < x - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (width / 2 - 1) - i), new string('.', 1 + 2 * i)); // part 4
        }

        for (int i = 0; i < x - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', z + i), new string('.', (width - 2 * z - 2) - 2 * i)); // part 5
        }

        Console.WriteLine("{0}*{0}", new string('.', z + x - 2)); // part 6 (like part 3)
    }
}
