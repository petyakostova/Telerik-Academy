using System;

namespace _1.Electricity
{
    class Electricity
    {
        static void Main()
        {
            double lampPower = 100.53;
            double compPower = 125.90;

            int numberOfFloors = int.Parse(Console.ReadLine());
            int flatsPerFloor = int.Parse(Console.ReadLine());

            DateTime time = DateTime.Parse(Console.ReadLine());

            DateTime firstStart = DateTime.Parse("00:00");
            DateTime firstEnd = DateTime.Parse("08:59");
            DateTime secondStart = DateTime.Parse("14:00");
            DateTime secondEnd = DateTime.Parse("18:59");
            DateTime thirdStart = DateTime.Parse("19:00");
            DateTime thirdEnd = DateTime.Parse("23:59");

            // power consumption for one flat
            double totalPower = 0;

            if (firstStart <= time && time <= firstEnd)
            {
                totalPower += lampPower + (compPower * 8);
            }
            else if (secondStart <= time && time <= secondEnd)
            {
                totalPower += (lampPower * 2) + (compPower * 2);
            }
            else if (thirdStart <= time && time <= thirdEnd)
            {
                totalPower += (lampPower * 7) + (compPower * 6);
            }

            totalPower *= numberOfFloors * flatsPerFloor;

            Console.WriteLine("{0} Watts", Math.Floor(totalPower));
            //Console.WriteLine("{0} Watts", (int)(totalPower));
        }
    }
}