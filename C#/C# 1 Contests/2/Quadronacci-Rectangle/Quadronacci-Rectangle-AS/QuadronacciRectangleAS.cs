using System;

class QuadronacciRectangleAS
{
    static void Main(string[] args)
    {
        try
        {
            checked
            {
                long first = long.Parse(Console.ReadLine());
                long second = long.Parse(Console.ReadLine());
                long third = long.Parse(Console.ReadLine());
                long fourth = long.Parse(Console.ReadLine());

                ulong rows = ulong.Parse(Console.ReadLine());
                ulong cols = ulong.Parse(Console.ReadLine());

                ulong lastToGenerate = rows * cols;

                if (cols > 4)
                {
                    Console.Write("{0} {1} {2} {3} ", first, second, third, fourth);
                }
                else
                {
                    Console.Write("{0} {1} {2} {3}", first, second, third, fourth);
                }

                for (ulong currentPosition = 5; currentPosition <= lastToGenerate; currentPosition++)
                {
                    if ((currentPosition - 1) % cols == 0)
                    {
                        Console.WriteLine();
                    }

                    long currentNumber = first + second + third + fourth;

                    if (currentPosition % cols != 0)
                    {
                        Console.Write(currentNumber + " ");
                    }
                    else
                    {
                        Console.Write(currentNumber);
                    }

                    first = second;
                    second = third;
                    third = fourth;
                    fourth = currentNumber;
                }
            }

            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine();
            Console.WriteLine("Overflow or other error");
        }
    }
}