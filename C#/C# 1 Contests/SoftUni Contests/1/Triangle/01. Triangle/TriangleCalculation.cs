using System;
using System.Threading;
using System.Globalization;

class TriangleCalculation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int aX = int.Parse(Console.ReadLine());
        int aY = int.Parse(Console.ReadLine());
        int bX = int.Parse(Console.ReadLine());
        int bY = int.Parse(Console.ReadLine());
        int cX = int.Parse(Console.ReadLine());
        int cY = int.Parse(Console.ReadLine());

        double sideA = Math.Sqrt(Math.Pow((cX - bX), 2) + Math.Pow((cY - bY), 2)); 
        double sideB = Math.Sqrt(Math.Pow((cX - aX), 2) + Math.Pow((cY - aY), 2));
        double sideC = Math.Sqrt(Math.Pow((aX - bX), 2) + Math.Pow((aY - bY), 2));

        if ((sideA + sideB > sideC) &&
            (sideC + sideB > sideA) &&
            (sideA + sideC > sideB))                                 
        {
            double halfPerimeter = (sideA + sideB + sideC) / 2.0;   //a,b,c are integers => 2.0 instead of 2

            double area = Math.Sqrt(halfPerimeter * 
                (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", sideC);
        }
    }
}