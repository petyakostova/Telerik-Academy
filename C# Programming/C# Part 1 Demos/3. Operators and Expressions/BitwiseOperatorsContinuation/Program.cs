using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = mask & number;
        result = result >> position;

        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else if (result == 0)
        {
            Console.WriteLine(false);
        }
        else
        {
            Console.WriteLine("Your program does not work!");
        }
    }
}
