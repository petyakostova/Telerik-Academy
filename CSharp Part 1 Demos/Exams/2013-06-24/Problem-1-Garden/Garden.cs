using System;

public class Garden
{
    public static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InstalledUICulture;

        int tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeeds = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeeds = int.Parse(Console.ReadLine());

        double tomatoCost = 0.5;
        double cucumberCost = 0.4;
        double potatoCost = 0.25;
        double carrotCost = 0.6;
        double cabbageCost = 0.3;
        double beansCost = 0.4;

        double totalCosts = tomatoSeeds * tomatoCost + cucumberSeeds * cucumberCost + potatoSeeds * potatoCost
            + carrotSeeds * carrotCost + cabbageSeeds * cabbageCost + beansSeeds * beansCost;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        int beansArea = 250 - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;
        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (beansArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            Console.WriteLine("Insufficient area");
        }
    }
}
