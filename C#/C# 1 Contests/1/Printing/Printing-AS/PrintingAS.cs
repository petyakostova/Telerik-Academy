using System;

public class PrintingAS
{
    public static void Main()
    {
        int sheetsInRealm = 500;

        int N = int.Parse(Console.ReadLine());
        int S = int.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double money = ((N * S) / (double)sheetsInRealm) * P;
        Console.WriteLine("{0:F2}", money);
    }
}