using System;

public class MoneyAS
{
    public static void Main()
    {
        int sheetsInRealm = 400;

        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double money = ((N * S) / (double)sheetsInRealm) * P;
        Console.WriteLine("{0:F3}", money);
    }
}