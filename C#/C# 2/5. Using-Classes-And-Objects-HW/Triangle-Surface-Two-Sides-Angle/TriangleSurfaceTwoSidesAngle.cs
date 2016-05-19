/*  6. Triangle surface by two sides and an angle
    Write program that calculates the surface of a triangle by given two sides and an angle between them.
    Input: 
            On the first line you will receive the length of the first side of the triangle
            On the second line you will receive the length of the second side of the triangle
            On the third line you will receive the angle between the given sides. Angle is given in degrees
    Output: Print the surface of the rectangle with two digits of precision
    Constraints: Input data describes a valid triangle
    Sample tests:
                    Input    	Output
                    10          14.79
                    7
                    25 	                            */

using System;

class TriangleSurfaceTwoSidesAngle
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angleAB = double.Parse(Console.ReadLine());

        double area;

        area = SidesAngleTriangleArea(sideA, sideB, angleAB);

        Console.WriteLine("{0:F2}", area);
    }

    public static double SidesAngleTriangleArea(double sideA, double sideB, double angleAB)
    {
        /* Returns the sine of the specified angle, measured in radians.
           (radians) = (degrees) * PI / 180
                public static double Sin(double a); */
        return (sideA * sideB * Math.Sin(angleAB * Math.PI / 180)) / 2;
    }

}