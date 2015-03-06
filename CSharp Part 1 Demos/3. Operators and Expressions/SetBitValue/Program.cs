using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine(result);
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Your program sucks!");
        }
    }
}
