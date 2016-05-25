using System;

class StaticMethods
{
    static void Main()
    {
        double radius = 2.9;
        Console.WriteLine("Circle radius: {0}", radius); // Circle radius: 2,9
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Circle area: {0}", area); // Circle area: 26,4207942166902
        Console.WriteLine();

        double precise = 8.7654321;
        double round3 = Math.Round(precise, 3);
        double round1 = Math.Round(precise, 1);
        Console.WriteLine("Precise: {0}", precise); //Precise: 8,7654321
        Console.WriteLine("Rounded to 0.1: {0}", round1); //Rounded to 0.1: 8,8
        Console.WriteLine("Rounded to 0.001: {0}", round3); //Rounded to 0.001: 8,765
    }
}