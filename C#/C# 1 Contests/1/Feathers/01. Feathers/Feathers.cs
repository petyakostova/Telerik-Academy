using System;
using System.Globalization;
using System.Threading;

class Feathers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        long birdsNumber = long.Parse(Console.ReadLine());
        long feathers = long.Parse(Console.ReadLine());

        double averageFeathers;

        if (birdsNumber > 0 && feathers > 0)
        {
            averageFeathers = feathers * 1.0 / birdsNumber;

            if (birdsNumber % 2 == 0)
            {
                averageFeathers *= 123123123123;
            }
            else
            {
                averageFeathers /= 317;
            }

            Console.WriteLine("{0:F4}", averageFeathers);
        }
        else
        {
            Console.WriteLine("{0:F4}", 0);
        }

    }
}