using System;

namespace Busses
{
    class BussesStartup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int groupsCount = 1;

            int firstInLineSpeed = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                int currentBusSpeed = int.Parse(Console.ReadLine());

                if (currentBusSpeed <= firstInLineSpeed)
                {
                    groupsCount++;
                    firstInLineSpeed = currentBusSpeed;
                }
            }

            Console.WriteLine(groupsCount);

        }
    }
}
