using System;

class TravellerBobAS
{
    static void Main()
    {
        //Reading input from the Console
        string leap = Console.ReadLine();
        int contract = int.Parse(Console.ReadLine());
        int family = int.Parse(Console.ReadLine());

        //Calculating total travels for each type of month
        int contractTravels = contract * (4 * 3);
        int familyTravels = (2 * 2) * family;
        double normalTravels = (((12 - contract - family) * 12) * 3 / 5.0);

        double totalTravels = contractTravels + familyTravels + normalTravels;

        //If the year is leap, 5% in addition
        if (leap == "leap")
        {
            totalTravels = totalTravels * 1.05;
        }

        //Printing the result
        Console.WriteLine((int)totalTravels);
    }
}