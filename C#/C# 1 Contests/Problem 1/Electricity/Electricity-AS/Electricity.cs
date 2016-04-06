using System;

public class Electricity
{
    public static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());

        int sumWats;
        if (time.Hour >= 14 && time.Hour <= 18)
        {
            // Noon time
            double noonConsumption = (2 * 100.53) + (2 * 125.90);
            sumWats = (int)(noonConsumption * flats * floors);
        }
        else if (time.Hour >= 19 && time.Hour <= 23)
        {
            // Afternoon time
            double afternoonConsumption = (7 * 100.53) + (6 * 125.90);
            sumWats = (int)(afternoonConsumption * flats * floors);
        }
        else if (time.Hour >= 0 && time.Hour <= 8)
        {
            // Midnight time
            double midnightConsumption = (1 * 100.53) + (8 * 125.90);
            sumWats = (int)(midnightConsumption * flats * floors);
        }
        else
        {
            // Any other time --> zero consumption
            sumWats = 0;
        }

        Console.WriteLine(sumWats + " Watts");
    }
}
