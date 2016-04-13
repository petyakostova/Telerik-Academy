using System;

class TravellerBob
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int contractMonths = int.Parse(Console.ReadLine());
        int familyMonths = int.Parse(Console.ReadLine());

        int monthsPerYear = 12;
        int normalMonths = monthsPerYear - contractMonths - familyMonths;

        double totalTravels = contractMonths * 12.0; // 4 weeks * 3 travels => 12 travels per month

        totalTravels += familyMonths * 4.0; // 2 weeks * 2 travels => 4 travels per month 

        totalTravels += normalMonths * 12.0 * 3 / 5; // 2/5 less than during contract months

        if (yearType == "leap")
        {
            totalTravels += totalTravels * 0.05;
        }

        Console.WriteLine(Math.Floor(totalTravels));
        //Console.WriteLine((int)totalTravels);
    }
}