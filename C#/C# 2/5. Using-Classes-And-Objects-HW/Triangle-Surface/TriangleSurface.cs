/*  Problem 4. Triangle surface
    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
 */
/* Note: Added file "Example-Triangle-Surface" with example for faster testing.
 */

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.Write("Enter sideA: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Enter sideB: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Enter sideC: ");
        double sideC = double.Parse(Console.ReadLine());
        Console.Write("Enter an altitude to sideA:  ");
        double altitudeToA = double.Parse(Console.ReadLine());
        Console.Write("Enter an angle between sideA and sideB: ");
        double angleAB = double.Parse(Console.ReadLine());

        double area;

        area = SideAltitudeTriangleArea(sideA, altitudeToA);
        Console.WriteLine("\nSide and an altitude to it: S={0:F1}", area);

        area = TreeSidesTriangleArea(sideA, sideB, sideC);
        Console.WriteLine("\nThree sides: S={0:F1}", area);

        area = SidesAngleTriangleArea(sideA, sideB, angleAB);
        Console.WriteLine("\nTwo sides and an angle between them: S={0:F1}\n", area);

    }

        public static double SideAltitudeTriangleArea(double side, double altitude)
    {
        return side * altitude / 2;
    }

    public static double TreeSidesTriangleArea(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

    public static double SidesAngleTriangleArea(double sideA, double sideB, double angleAB)
    {
        return (sideA * sideB * Math.Sin(Math.PI / 180 * angleAB)) / 2;
    }
}