/*  5. Triangle surface by three sides
    Write program that calculates the surface of a triangle by given its three sides.
    Input: 
            On the first line you will receive the length of the first side of the triangle
            On the second line you will receive the length of the second side of the triangle
            On the third line you will receive the length of the third side of the triangle
    Output: Print the surface of the rectangle with two digits of precision
    Constraints: Input data describes a valid triangle
    Sample tests:
                    Input 	Output
                    11      61.48
                    12
                    13 	                        */

using System;

class TriangleSurfaceThreeSides
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());

        double area;

        area = TreeSidesTriangleArea(sideA, sideB, sideC);

        Console.WriteLine("{0:F2}", area);
    }

    // Heron's formula
    public static double TreeSidesTriangleArea(double sideA, double sideB, double sideC)
    {
        double p = (sideA + sideB + sideC) / 2;

        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
    }

}