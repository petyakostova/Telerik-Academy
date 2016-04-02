// sum all odd numbers in [1...n], not divisors of 7
using System;

class SumOdd
{
	static void Main()
	{
		Console.Write("n = ");
        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);

		int sum = 0;

		for (int i = 1; i <= n; i += 2)
		{
			if ((i % 7) == 0)
            {
                // bypasses the current iteration of the inner-most loop without exits the inner-most loop
                continue;
            }
            sum += i;
		}
		Console.WriteLine("sum = {0}", sum);
	}
}