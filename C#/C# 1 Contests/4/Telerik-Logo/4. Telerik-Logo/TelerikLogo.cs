using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        //int y = x;
        int z = x / 2 + 1;

        int width = (2 * x + 2 * z) - 3;
        // height = width; //3 * x - 3

        Console.WriteLine("{0}*{1}*{0}", new string('.', z - 1), new string('.', width - 2 * z)); // part 1

        int specialCasesCount = 0; // special cases in part 2
        int fix = 0; // for fixing the more dotsIn in special cases
        for (int j = 7; j <= x; j += 2)
        {
            specialCasesCount++;
        }

        for (int i = 0; i < x - 2; i++)
        {
            int dotsOut = (z - 2) - i;
            int dotsIn = 1 + 2 * i;

            if (dotsIn < 0)
            {
                dotsIn = 0;
            }
            if (dotsOut < 0)
            {
                dotsOut = 0;
            }            

            if (i >= ((x - 2 - 1) - specialCasesCount) && x != 3) // on the last iteration is different; exception if x==3
            {
                dotsIn -= fix;                            
                Console.WriteLine("{0}*{1}*{0}",
                new string('.', (dotsIn)), new string('.', (width - 2 * z - 2) - 2 * i)); // part 2
                fix++;
            }
            else
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
                new string('.', dotsOut), new string('.', dotsIn), new string('.', (width - 2 * z - 2) - 2 * i)); // part 2
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