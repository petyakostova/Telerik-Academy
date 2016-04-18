using System;

class PeaceOfCake
{
    static void Main()
    {

        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());

        long nominator = a * d + c * b;
        long denominator = b * d;

        if (nominator >= denominator)
        {
            Console.WriteLine(nominator / denominator);
        }
        else
        {
            Console.WriteLine("{0:F22}", (decimal)nominator / denominator);
        }

        Console.WriteLine("{0}/{1}", nominator, denominator);
    }
}