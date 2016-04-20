using System;

class TribonacciTriangle
{
    static void Main()
    {
        long firstNum = long.Parse(Console.ReadLine());
        long secondNum = long.Parse(Console.ReadLine());
        long thirdNum = long.Parse(Console.ReadLine());
        long lines = long.Parse(Console.ReadLine());

        // print the first line
        Console.WriteLine(firstNum);

        // print the second line
        if (lines >= 2)
        {
            Console.WriteLine("{0} {1}", secondNum, thirdNum);
        }

        long nextNum;

        if (lines > 2)
        {
            for (int i = 3; i <= lines; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    nextNum = firstNum + secondNum + thirdNum;
                    if (j == 0)
                    {
                        Console.Write(nextNum);
                    }
                    else
                    {
                        Console.Write(" {0}", nextNum);
                    }
                    firstNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = nextNum;
                }

                Console.WriteLine();
            }
        }

    }
}