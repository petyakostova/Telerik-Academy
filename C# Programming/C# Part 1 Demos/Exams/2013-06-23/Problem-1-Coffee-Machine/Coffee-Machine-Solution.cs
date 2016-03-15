using System;
using System.Threading;
using System.Globalization;

class CoffeeVendingMachine
{
    static void Main()
    {
		// Ensure the decimal separator is ".", not "," or any other
		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
	
		// Read the input
        int trayOne = int.Parse(Console.ReadLine());
        int trayTwo = int.Parse(Console.ReadLine());
        int trayThree = int.Parse(Console.ReadLine());
        int trayFour = int.Parse(Console.ReadLine());
        int trayFive = int.Parse(Console.ReadLine());
        decimal givenAmount = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

		// Check the 3 possible cases
        if (givenAmount < drinkPrice)
        {
            decimal difference = drinkPrice - givenAmount;
            Console.WriteLine("More {0:F2}", difference);
        }
        else
        {
            decimal moneyInTrays = 
				0.05m * trayOne + 
				0.10m * trayTwo + 
				0.20m * trayThree + 
				0.50m * trayFour + 
				1.00m * trayFive;
            decimal changeToGive = givenAmount - drinkPrice;
            decimal difference = Math.Abs(moneyInTrays - changeToGive);
            
            if (changeToGive <= moneyInTrays)
            {
                Console.WriteLine("Yes {0:F2}", difference);
            }
            else
            {
                Console.WriteLine("No {0:F2}", difference);
            }
        }
    }
}
