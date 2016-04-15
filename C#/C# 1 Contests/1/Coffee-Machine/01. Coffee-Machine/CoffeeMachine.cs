using System;
using System.Globalization;
using System.Threading;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int n5 = int.Parse(Console.ReadLine());
        decimal amount = decimal.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        if (price > amount)
        {
            Console.WriteLine("More {0:F2}", price - amount);
        }
        else
        {
            decimal moneyInMashine = 0.05m * n1 + 0.10m * n2 + 0.20m * n3 + 0.50m * n4 + 1.00m * n5;
            decimal change = amount - price;

            if (change > moneyInMashine)
            {
                Console.WriteLine("No {0:F2}", change - moneyInMashine);
            }
            else
            {
                Console.WriteLine("Yes {0:F2}", moneyInMashine - change);
            }

        }

    }
}