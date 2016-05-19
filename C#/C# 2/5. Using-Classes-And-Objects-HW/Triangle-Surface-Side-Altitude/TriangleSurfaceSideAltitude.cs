/*  4. Triangle surface by side and altitude
    Write program that calculates the surface of a triangle by given a side and an altitude to it.
    Input:
            On the first line you will receive the length of a side of the triangle
            On the second line you will receive the altitude to that side
    Output: Print the surface of the rectangle with two digits of precision
    Constraints: Input data describes a valid triangle
    Sample tests:
                    Input 	Output
                    23.2    58.00
                    5 	                        */

using System;

class TriangleSurfaceSideAltitude
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double altitudeToA = double.Parse(Console.ReadLine());

        double area;

        area = SideAltitudeTriangleArea(sideA, altitudeToA);

        Console.WriteLine("{0:F2}", area);
    }

    public static double SideAltitudeTriangleArea(double side, double altitude)
    {
        return side * altitude / 2;
    }

}