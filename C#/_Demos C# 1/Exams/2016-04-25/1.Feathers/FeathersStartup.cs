using System;

namespace Feathers
{
    class FeathersStartup
    {
        static void Main()
        {
            const ulong multiplier = 123123123123;
            const uint divisor = 317;

            ulong birdsCount = ulong.Parse(Console.ReadLine());
            ulong feathersCount = ulong.Parse(Console.ReadLine());

            if (birdsCount == 0 || feathersCount == 0)
            {
                Console.WriteLine("0.0000");
                return;
            }

            double feathersPerBird = (double)feathersCount / birdsCount;
            double result = birdsCount % 2 == 0 ? feathersPerBird * multiplier : feathersPerBird / divisor;

            Console.WriteLine("{0:F4}", result);
        }
    }
}
